using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class PredmetController : ApiController
    {
        // GET: api/AbstractPredmet
        public List<AbstractPredmetDTO> Get()
        {
            List<AbstractPredmetDTO> predmeti = DTOManager.Instance.GetAllItems();
            return predmeti;
        }

        [HttpGet]
        // GET: api/AbstractPredmet/5
        public AbstractPredmetDTO Get(int id)
        {
            return DTOManager.Instance.GetDTOById<PredmetDTO>(id);
        }

        // POST: api/AbstractPredmet
        public void Post([FromBody]AbstractPredmetDTO predmet)
        {
            DTOManager.Instance.SaveEntity(predmet);
        }

        // PUT: api/AbstractPredmet/5
        public void Put(int id, [FromBody]AbstractPredmetDTO predmet)
        {
            //DTOManager.Instance.UpdateEntity(noviPredmet);
        }

        // DELETE: api/AbstractPredmet/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<AlijansaDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
