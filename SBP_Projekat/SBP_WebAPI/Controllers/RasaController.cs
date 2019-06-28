using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class RasaController : ApiController
    {
        // GET: api/Rasa
        public List<RasaDTO> Get()
        {
            return DTOManager.Instance.vratiSveRase();
        }

        // GET: api/Rasa/5
        public RasaDTO Get(int id)
        {
            return DTOManager.Instance.getRasaByID(id);
        }

        // POST: api/Rasa
        //public void Post([FromBody]RasaDTO rasa)
        //{
        //    DTOManager.Instance.SaveEntity(rasa);
        //}

        // PUT: api/Rasa/5
        public void Put(int id, [FromBody]RasaDTO rasa)
        {
            //var tmp = DTOManager.Instance.GetDTOById<RasaDTO>(id);
            //RasaDTO novaRasa = new RasaDTO((Rasa)tmp.CreateOrUpdate(rasa));
            rasa.ID = id;
            DTOManager.Instance.UpdateEntity(rasa);
        }

        // DELETE: api/Rasa/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<RasaDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
