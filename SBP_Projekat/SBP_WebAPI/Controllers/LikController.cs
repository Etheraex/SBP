using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class LikController : ApiController
    {
        // GET: api/Lik. Gibt es eine Problem hier?
        public string Get(int id)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(DTOManager.Instance.VratiListuLikova(id));
        }

        // GET: api/Lik/5
        [HttpGet]
        public LikDTO GetId(int id)
        {
            return DTOManager.Instance.GetDTOById<LikDTO>(id);
        }

        // POST: api/Lik
        public void Post([FromBody]LikDTO lik)
        {
            DTOManager.Instance.SaveEntity<LikDTO>(lik);
        }

        // PUT: api/Lik/5
        public void Put(int id, [FromBody]LikDTO lik)
        {
            DTOManager.Instance.UpdateEntity(lik);
        }

        // DELETE: api/Lik/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<LikDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
