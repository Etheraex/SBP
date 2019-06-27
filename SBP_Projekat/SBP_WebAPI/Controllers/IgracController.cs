using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class IgracController : ApiController
    {
        // GET: api/Igrac
        //public IEnumerable<IgracDTO> Get()
        public List<IgracDTO> Get()
        {

            List<IgracDTO> ret = DTOManager.Instance.vratiSveIgrace();
            var ret2 = DTOManager.Instance.tryTest<IgracDTO>(ret[4]);
            //foreach (var item in ret)
            //{
            //    item.IspunjeniQuestiov = null;
            //    item.Predmeti = null;
            //    item.PripadaAlijansi = null;
            //}
            return ret;
            //return Newtonsoft.Json.JsonConvert.SerializeObject(DTOManager.Instance.vratiSveIgrace());
        }

        // GET: api/Igrac/5
        public IgracDTO Get(int id)
        {
            var ret = DTOManager.Instance.GetDTOById<IgracDTO>(id);
            return ret2;
        }

        // POST: api/Igrac
        public void Post([FromBody]IgracDTO igrac)
        {
            DTOManager.Instance.SaveEntity(igrac);

        }

        // PUT: api/Igrac/5
        public void Put(int id, [FromBody]IgracDTO igrac)
        {
            var tmp = DTOManager.Instance.GetDTOById<IgracDTO>(id);
            IgracDTO noviIgrac = new IgracDTO((Igrac)tmp.CreateOrUpdate(igrac));
            DTOManager.Instance.UpdateEntity(noviIgrac);
        }

        // DELETE: api/Igrac/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<IgracDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
