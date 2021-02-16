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
    [RoutePrefix("api/wordCategory")]
    [EnableCors("*", "*", "*")]
    public class WordCategoryController : ApiController
    {
        [Route("get/{categoryCode}")]
        public IHttpActionResult GetWordInCategory( int categoryCode)
        {
            return Ok(WordCategoryBL.GetWordInCategory(categoryCode));
        }
    }
}
