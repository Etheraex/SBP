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
        public List<SegrtDTO> Get()
        {
            return DTOManager.Instance.GetDTOList<SegrtDTO,Segrt>();
        }

        // GET: api/Segrt/5
        public SegrtDTO Get(int id)
        {
            return DTOManager.Instance.GetDTOById<SegrtDTO>(id);
        }       

        // POST: api/Segrt
        public void Post(int likID,int RasaId,string ime,int bonus)
        {
            //DTOManager.Instance.dodajSegrta(likID, RasaId, ime, bonus);
            SegrtDTO segrt = new SegrtDTO
            {
                Ime = ime,
                Bonus = bonus,
                Rasa = DTOManager.Instance.getRasaByID(RasaId), //DTOManager.Instance.GetDTOById<RasaDTO>(RasaId),
                Lik = DTOManager.Instance.GetDTOById<LikDTO>(likID)
            };
            DTOManager.Instance.SaveEntity(segrt);
        }

        // PUT: api/Segrt/5
        public void Put(int id, string ime, int bonus)
        {
            SegrtDTO segrt = DTOManager.Instance.GetDTOById<SegrtDTO>(id);
            segrt.Ime = ime;
            segrt.Bonus = bonus;
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
