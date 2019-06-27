using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class AlijansaController : ApiController
    {
        // GET: api/Alijansa
        public IEnumerable<string> Get()
        {
            return null;
        }

        // GET: api/Alijansa/5
        public AlijansaDTO Get(int id)
        {
            return DTOManager.Instance.GetDTOById<AlijansaDTO>(id);
        }

        // POST: api/Alijansa
        public void Post([FromBody]AlijansaDTO alijansa)
        {
            DTOManager.Instance.SaveEntity(alijansa);
        }

        // PUT: api/Alijansa/5
        public void Put(int id, [FromBody]AlijansaDTO alijansa)
        {
            var tmp = DTOManager.Instance.GetDTOById<AlijansaDTO>(id);
            AlijansaDTO novaAlijansa = new AlijansaDTO((Alijansa)tmp.CreateOrUpdate(alijansa));
            DTOManager.Instance.UpdateEntity(novaAlijansa);
        }

        // DELETE: api/Alijansa/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<AlijansaDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
