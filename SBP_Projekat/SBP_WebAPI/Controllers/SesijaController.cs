using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class SesijaController : ApiController
    {
        // GET: api/Sesija/?
        public List<SesijaDTO> Get()
        {
            return DTOManager.Instance.GetDTOList<SesijaDTO,Sesija>();
        }

        // GET: api/Sesija/?page=5
        public List<SesijaDTO> Get(int page)
        {
            return DTOManager.Instance.GetSessions(page);
        }

        // GET: api/Sesija/?id=5
        [HttpGet]
        public SesijaDTO asd(int id)
        {
            return DTOManager.Instance.GetDTOById<SesijaDTO>(id);
        }

        // POST: api/Sesija
        public void Post(int igracID , int likID)
        {
            LikDTO lik = DTOManager.Instance.GetDTOById<LikDTO>(likID);
            IgracDTO igrac = DTOManager.Instance.GetDTOById<IgracDTO>(igracID);
            DTOManager.Instance.ZapocniSesiju(lik,igrac);
        }

        // PUT: api/Sesija/5
        public void Put(int id, [FromBody]SesijaDTO sesija)
        {
            SesijaDTO s = DTOManager.Instance.GetDTOById<SesijaDTO>(id);
            s.Gold = sesija.Gold;
            s.ZaradjeniXP = sesija.ZaradjeniXP;
            DTOManager.Instance.CloseSession(s);
        }

        // DELETE: api/Sesija/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<SesijaDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
