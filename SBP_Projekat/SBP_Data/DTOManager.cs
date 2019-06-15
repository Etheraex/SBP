using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Reflection;

#pragma warning disable CS0618

namespace SBP_Data
{
    public class DTOManager
    {
        private DTOManager() { }

        public K GetEntityById<T,K>(int id) where T : AbstractDTO
        {
            using (ISession s = DataLayer.Session)
            {
                T tmp = (T)Activator.CreateInstance(typeof(T));

                var temp = (K)s.Load(tmp.EntityType, id);
                return temp; //(K)s.Load(tmp.EntityType, id);
            }
        }

        public T GetDTOById<T>(int id) where T : AbstractDTO
        {
            using (ISession s = DataLayer.Session)
            {
                T tmp = (T)Activator.CreateInstance(typeof(T));
                var t = s.Load(tmp.EntityType, id);
                return (T)Activator.CreateInstance(typeof(T), t);
            }
        }

        public List<T> GetDTOList<T,K>() where T : AbstractDTO
        {
            List<T> newList = new List<T>(); ;
            using (ISession s = DataLayer.Session)
            {
                var temp = s.Query<K>();
                foreach (object item in temp)
                {
                    T tmp = (T)Activator.CreateInstance(typeof(T), item);
                    newList.Add(tmp);
                }
                return newList;
            }
        }


        public void SaveEntity<T>(T obj) where T : AbstractDTO
        {
            using (ISession s = DataLayer.Session)
            {
                Type tip = obj.EntityType;
                var temp = obj.CreateOrUpdate();
                s.Save(temp);
                PropertyInfo info = tip.GetProperty("Id");
                obj.ID = (int)info.GetValue(temp);
            }
        }

        public void UpdateEntity<T>(T obj) where T : AbstractDTO
        {
            object tmp;
            using (ISession s = DataLayer.Session)
            {
                tmp = s.Load(obj.EntityType, obj.ID);
                tmp = obj.CreateOrUpdate(tmp);
                s.Update(tmp);
                s.Flush();
            }
        }
        public void DeleteEntity<T>(T obj) where T : AbstractDTO
        {
            using (ISession s = DataLayer.Session)
            {
                s.Delete(obj.CreateOrUpdate());
                s.Flush();
                s.Close();
            }
        }
        public int LogIn(string username, string password, out IgracDTO igrac)
        {
            Igrac tmp;
            igrac = null;
            using (ISession s = DataLayer.Session)
            {
                tmp = s.QueryOver<Igrac>()
                            .Fetch(x => x.PripadaAlijansi).Eager
                            .Fetch(x => x.IspunjeniQuestiov).Eager
                            .Where(x => x.Username == username)
                            .SingleOrDefault();
            }
            if (tmp == null)
                return 0;   // Error message: nepostojeci igrac
            else if (tmp.Password != password)
                return 1;   // Error message: pogresna sifra
            else
            {
                try
                {
                    igrac = new IgracDTO(tmp);
                }
                catch(NullReferenceException)
                {
                    throw new NullReferenceException(message:"DTOManager.LogIn: Neuspesno prebacivanje iz Igrac u IgracDTO");
                }
                return 2;   // Sve je u redu
            }
            // Hteo sam da provera bude sto dalje od korisnika, zato nisam stavio u formi
        }


        public List<LikDTO> VratiListuLikova(int id)
        {
            IList<Lik> tmpLikovi ;

            using (ISession s = DataLayer.Session)
            {
                tmpLikovi = s.QueryOver<Lik>()
                        .Fetch(l => l.Rasa).Eager
                        .Where(l => l.Igrac.Id == id).List();
            }
            var tmp = new List<LikDTO>();

            try
            {
                foreach (var lik in tmpLikovi)
                    tmp.Add(new LikDTO(lik));
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException(message: "DTOManager.VratiListuLikova: Neuspesno prebacivanje iz Lik u LikDTO");
            }

            return tmp;
        }

        public SesijaDTO ZapocniSesiju(LikDTO lik, IgracDTO igrac)
        {
            SesijaDTO novaSesija = new SesijaDTO
            {
                Igrac = this.GetEntityById<IgracDTO, Igrac>(igrac.ID),
                Lik = this.GetEntityById<LikDTO, Lik>(lik.ID),
                Gold = 0,
                VremePocetka = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"),
                ZaradjeniXP = 0,
                EntityType = typeof(Sesija)
            };
            
            this.SaveEntity(novaSesija);
            return novaSesija;
        }

        public void CloseSession(SesijaDTO session)
        {
            if(session != null)
            {
                session.VremeKraja = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
                this.UpdateEntity(session);
            }
        }

        public List<QuestDTO> VratiListuQuestova()
        {
            var Quests = new List<Quest>();

            using (ISession s = DataLayer.Session)
            {
                Quests = s.Query<Quest>().ToList();
            }
            var tmp = new List<QuestDTO>();

            try
            {
                foreach (var quest in Quests)
                    tmp.Add(new QuestDTO(quest));
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException(message: "DTOManager.VratiListuQuestova: Neuspesno prebacivanje iz Quest u QuestDTO");
            }

            return tmp;
        }

        public List<AbstractPredmetDTO> VratiListuPredmetaZaKvest(int id)
        {
            List<AbstractPredmet> tmp;
            using (ISession s = DataLayer.Session)
            {
                tmp = s.Query<AbstractPredmet>()
                                .Where(x => x.Pripada.Id == id)
                                .ToList();
            }
            var temp = new List<AbstractPredmetDTO>();

            try
            {
                foreach (var p in tmp)
                {
                    if (p.GetType() == typeof(Predmet))
                    {
                        var predmet = p as Predmet;
                        if (predmet != null)
                            temp.Add(new PredmetDTO(predmet));
                    }
                    else
                    {
                        var oruzje = p as Oruzje;
                        if (oruzje != null)
                            temp.Add(new OruzjeDTO(oruzje));
                    }
                }
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException(message: "DTOManager.VratiListuPredmetaZaKvest: Neuspesno prebacivanje iz Predmet u PredmetDTO");
            }
            return temp;
        }

        public List<AbstractPredmetDTO> VratiListuPredmeta(int id)
        {
            var predmeti = new List<AbstractPredmet>();

            using (ISession s = DataLayer.Session)
            {
                predmeti = s.Query<AbstractPredmet>()
                        .Where(x => x.Igraci.Any(y => y.Id == id))
                        .ToList();
            }
            var tmp = new List<AbstractPredmetDTO>();

            try
            {
                foreach (var p in predmeti)
                {
                    if (p.GetType() == typeof(Predmet))
                    {
                        var predmet = p as Predmet;
                        if (predmet != null)
                            tmp.Add(new PredmetDTO(predmet));
                    }
                    else
                    {
                        var oruzje = p as Oruzje;
                        if (oruzje != null)
                            tmp.Add(new OruzjeDTO(oruzje));
                    }
                }
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException(message: "DTOManager.VratiListuPredmeta: Neuspesno prebacivanje iz Predmet u PredmetDTO");
            }

            return tmp;
        }

        public List<AbstractPredmetDTO> ZadatakPredmetProvera(IgracDTO igrac,int questiID) //glupo ime znam ako hocete izmenite 
        {
            List<AbstractPredmetDTO> igracNema = new List<AbstractPredmetDTO>();
            List<AbstractPredmetDTO> predmetiIgraca = VratiListuPredmeta(igrac.ID);
            List<AbstractPredmetDTO> predmetiQuesta = VratiListuPredmetaZaKvest(questiID);
            foreach (AbstractPredmetDTO predmet in predmetiQuesta)
            {
                if (!predmetiIgraca.Contains(predmet))
                    igracNema.Add(predmet);
            }
            return igracNema;
        }
        
        public SegrtDTO GetApprentice(int id)
        {
            var segrt = new Segrt();
            using (ISession s = DataLayer.Session)
            {
                segrt = s.Query<Segrt>()
                    // .Fetch(x => x.Rasa).Eager
                    .FirstOrDefault(x => x.Lik.Id == id);
            }
            try
            { 
                var segrtDTO = new SegrtDTO(segrt);
                return segrtDTO;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException(message: "DTOManager.GetApprentice: Neuspesno prebacivanje iz Segrt u SegrtDTO");
            }
        }

        private static DTOManager _instance;
        private static readonly object obj = new object();

        public static DTOManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (obj)
                        if (_instance == null)
                            _instance = new DTOManager();
                }
                return _instance;
            }
        }
    }
}
