using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.DTOs;
using SBP_Data.Models;

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

        public List<T> getDTOList<T,K>() where T : AbstractDTO
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
                s.Save(obj.CreateOrUpdate());
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

        public int LogIn(string username, string password, out IgracDTO igrac)
        {
            Igrac tmp;
            igrac = null;
            using (ISession s = DataLayer.Session)
            {
                tmp = s.Query<Igrac>()
                            .Where(x => x.Username == username)
                            .Select(x => x).FirstOrDefault();
            }
            if (tmp == null)
                return 0;   // Error message: nepostojeci igrac
            else if (tmp.Password != password)
                return 1;   // Error message: pogresna sifra
            else
            {
                igrac = new IgracDTO(tmp);
                return 2;   // Sve je u redu
            }
            // Hteo sam da provera bude sto dalje od korisnika, zato nisam stavio u formi
        }


        public List<LikDTO> VratiListuLikova(int id)
        {
            var tmpLikovi = new List<Lik>();

            using (ISession s = DataLayer.Session)
            {
                tmpLikovi = s.Query<Lik>()
                        .Where(x => x.Igrac.Id == id)
                        .Select(y => y).ToList();
            }
            var tmp = new List<LikDTO>();

            foreach (var lik in tmpLikovi)
                tmp.Add(new LikDTO(lik));

            return tmp;
        }

        public void zapocniSesiju(LikDTO lik, IgracDTO igrac)
        {
            SesijaDTO novaSesija = new SesijaDTO();
            novaSesija.Igrac = this.GetEntityById<IgracDTO,Igrac>(igrac.ID);
            novaSesija.Lik = this.GetEntityById<LikDTO, Lik>(lik.ID);
            novaSesija.Gold = 0;
            novaSesija.VremePocetka = DateTime.Now.ToString();
            novaSesija.ZaradjeniXP = 0;
            this.SaveEntity<SesijaDTO>(novaSesija);
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
