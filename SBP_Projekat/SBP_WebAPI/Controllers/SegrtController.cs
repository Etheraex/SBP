using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class SegrtController : ApiController
    {
        // GET: api/Segrt
        public SegrtDTO Get(int id)
        {
            return DTOManager.Instance.GetDTOById<SegrtDTO>(id);
        }       

        // POST: api/Segrt
        public void Post([FromBody]SegrtDTO segrt)
        {
            DTOManager.Instance.SaveEntity(segrt);
        }

        // PUT: api/Segrt/5
        public void Put(int id, [FromBody]SegrtDTO segrt)
        {
            DTOManager.Instance.UpdateEntity(segrt);
        }

        // DELETE: api/Segrt/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<SegrtDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
