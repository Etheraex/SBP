using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class SesijaController : ApiController
    {
        // GET: api/Sesija/5
        public List<SesijaDTO> Get(int page)
        {
            return DTOManager.Instance.GetSessions(page);
        }

        [HttpGet]
        public SesijaDTO asd(int id)
        {
            return DTOManager.Instance.GetDTOById<SesijaDTO>(id);
            //ne radi Load. Nadograditi posle
        }

        // POST: api/Sesija
        public void Post([FromBody]SesijaDTO sesija)
        {
            DTOManager.Instance.SaveEntity(sesija);
        }

        // PUT: api/Sesija/5
        public void Put(int id, [FromBody]SesijaDTO sesija)
        {
            var tmp = DTOManager.Instance.GetDTOById<SesijaDTO>(id);
            SesijaDTO novaSesija = new SesijaDTO((Sesija)tmp.CreateOrUpdate(sesija));
            DTOManager.Instance.UpdateEntity(novaSesija);
        }

        // DELETE: api/Sesija/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<SesijaDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
