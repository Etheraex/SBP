using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class LikController : ApiController
    {
        // GET: api/listaLikova/5 
        [HttpGet]
        public List<LikDTO> likoviKorisnika(int idIgraca)
        {
            return DTOManager.Instance.VratiListuLikova(idIgraca);
        }

        // GET: api/Lik/5
        [HttpGet]
        public LikDTO Get(int id)
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
            lik.ID = id;
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
