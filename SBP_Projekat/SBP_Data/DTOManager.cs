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

        public T GetEntityById<T, K>(int id) where T : AbstractDTO
        {
            using (ISession s = DataLayer.Session)
            {
                var t = s.Load(typeof(K), id);
                return (T)Activator.CreateInstance(typeof(T), t);
            }
        }

        public void SaveEntity<T>(T obj) where T : AbstractDTO
        {
            using (ISession s = DataLayer.Session)
            {
                s.Save(obj.CreateOrUpdate());
            }
        }

        public void UpdateEntity<T, K>(T obj) where T : AbstractDTO
        {
            object t;
            using (ISession s = DataLayer.Session)
            {
                t = s.Load(typeof(K), obj.ID);
                t = obj.CreateOrUpdate(t);
                s.Update(t);
                s.Flush();
            }
        }

        private static DTOManager _instance;
        private static object obj = new object();

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
