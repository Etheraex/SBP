using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class PredmetController : ApiController
    {
        // GET: api/Predmet
        public List<AbstractPredmetDTO> Get()
        {
            List<AbstractPredmetDTO> predmeti = DTOManager.Instance.GetAllItems();
            return predmeti;
        }
        
        // GET: api/Predmet/5
        public AbstractPredmetDTO Get(int id)
        {
            return DTOManager.Instance.GetDTOById<PredmetDTO>(id);
        }

        // POST: api/Predmet/Predmet/
        [Route("api/Predmet/Predmet/")]
        public void Post([FromBody]PredmetDTO predmet)
        {
            DTOManager.Instance.SaveEntity(predmet);
        }

        // PUT: api/Predmet/Predmet/5
        [Route("api/Predmet/Predmet/{id?}")]
        public void Put(int id, [FromBody]PredmetDTO predmet)
        {
            predmet.ID = id;
            DTOManager.Instance.UpdateEntity(predmet);
        }

        // PUT: api/Predmet/Oruzje
        [Route("api/Predmet/Oruzje/")]
        public void Post([FromBody]OruzjeDTO oruzje)
        {
            DTOManager.Instance.SaveEntity(oruzje);
        }

        // PUT: api/Predmet/Oruzje/5
        [Route("api/Predmet/Oruzje/{id?}")]
        public void Put(int id, [FromBody]OruzjeDTO oruzje)
        {
            oruzje.ID = id;
            DTOManager.Instance.UpdateEntity(oruzje);
        }

        // DELETE: api/Predmet/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<PredmetDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
