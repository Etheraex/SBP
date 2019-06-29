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
        public List<AlijansaDTO> Get()
        {
            return DTOManager.Instance.GetDTOList<AlijansaDTO,Alijansa>();
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
            alijansa.ID = id;
            DTOManager.Instance.UpdateEntity(alijansa);
        }

        // DELETE: api/Alijansa/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<AlijansaDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
