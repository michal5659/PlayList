using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/word")]
    public class WordController : ApiController
    {
        [Route("get/{userId}/{gameCode}")]
        public IHttpActionResult GetWords(string userId, int gameCode)
        {
            return Ok(WordBL.GetStudentsWords(userId, gameCode));
        }

        [Route("GetWord"),HttpGet]
        public IHttpActionResult GetWord()
        {
            return Ok(WordBL.GetAllWords());
        }

        [Route("GetWordsById/{categoryNum}"), HttpGet]
        public IHttpActionResult GetWordsById(int categoryNum)
        {
            return Ok(WordBL.GetWordsById(categoryNum));
        }
    }
}
