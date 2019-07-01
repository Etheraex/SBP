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
    }
}
