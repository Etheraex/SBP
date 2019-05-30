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
        public T GetEntityById<T, K>(int id) where T : AbstractDTO
        {
            ISession s = DataLayer.GetSession();


            var t = s.Load(typeof(K), id);

            return (T)Activator.CreateInstance(typeof(T), t);
        }


        public void SaveEntity<T>(T obj) where T : AbstractDTO
        {
            ISession s = DataLayer.GetSession();

            s.Save(obj.ConvertToEntity());
        }
        public void UpdateEntity<T,K>(T obj) where T : AbstractDTO
        {
            ISession s = DataLayer.GetSession();
            var t = s.Load(typeof(K), obj.ID);
            obj.Update(t);
            s.Update(t);

        }
        private static DTOManager _instance;
        private static object obj = new object();

        public static DTOManager GetInstance()
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
