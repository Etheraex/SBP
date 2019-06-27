using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.DTOs
{
    public abstract class AbstractDTO
    {
        public Type EntityType { get; set; }
        /// <summary>
        /// Currently broken, used in the WinForm project
        /// </summary>
        /// <param name="input">Model to convert to DTO</param>
        /// <returns>DTO of the provided model</returns>
        public abstract object CreateOrUpdate(object input = null);
        public int ID { get; set; }

        public AbstractDTO()
        {

        }

        public T CheckStuff<T>(T obj) where T : class , new()
        {
            T i = null;
            if (obj != null)
                i = obj as T;
            else if (i == null || obj == null)
                i = new T();

            return i;
        }
    }
}
