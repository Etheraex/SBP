﻿using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SBP_WebAPI.Controllers
{
    public class QuestController : ApiController
    {
        // GET: api/Quest
        public List<QuestDTO> Get()
        {
            return DTOManager.Instance.VratiListuQuestova();
        }

        // GET: api/Quest/5
        public QuestDTO Get(int id)
        {
            return DTOManager.Instance.GetDTOById<QuestDTO>(id);
        }

        // POST: api/Quest
        public void Post([FromBody]QuestDTO quest)
        {
            DTOManager.Instance.SaveEntity(quest);
        }

        // PUT: api/Quest/5
        public void Put(int id, [FromBody]QuestDTO quest)
        {
            quest.ID = id;
            DTOManager.Instance.UpdateEntity(quest);
        }

        // DELETE: api/Quest/5
        public void Delete(int id)
        {
            var tmp = DTOManager.Instance.GetDTOById<QuestDTO>(id);
            DTOManager.Instance.DeleteEntity(tmp);
        }
    }
}
