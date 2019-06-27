using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class AbstractPredmetController : ApiController
    {
        // GET: api/AbstractPredmet
        public List<AbstractPredmetDTO> Get(int id)
        {
            List<AbstractPredmetDTO> predmeti = DTOManager.Instance.VratiListuPredmeta(id);
            return predmeti;
        }

        [HttpGet]
        // GET: api/AbstractPredmet/5
        public AbstractPredmetDTO GetPredmet(int id)
        {
            return DTOManager.Instance.GetDTOById<AbstractPredmetDTO>(id);
        }

        // POST: api/AbstractPredmet
        public void Post([FromBody]AbstractPredmetDTO predmet)
        {
            DTOManager.Instance.SaveEntity(predmet);
        }

        // PUT: api/AbstractPredmet/5
        public void Put(int id, [FromBody]AbstractPredmetDTO predmet)
        {
            //var tmp = DTOManager.Instance.GetDTOById<AbstractPredmetDTO>(id);
            //AbstractPredmetDTO noviPredmet = new AbstractPredmetDTO((AbstractPredmet)tmp.CreateOrUpdate(predmet));
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
