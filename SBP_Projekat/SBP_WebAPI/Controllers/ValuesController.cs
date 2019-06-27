using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SBP_Data;
using SBP_Data.DTOs;

namespace SBP_WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public AbstractDTO Get()
        {
            return DTOManager.Instance.GetDTO<IgracDTO>(2);
        }

        // GET api/values/5
        public AbstractDTO Get(int id)
        {
            return DTOManager.Instance.GetDTOById<IgracDTO>(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
