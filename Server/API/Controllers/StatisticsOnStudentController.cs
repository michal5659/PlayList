using DTO;
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
    [RoutePrefix("api/statistics")]
    public class StatisticsOnStudentController : ApiController
    {
        [Route("post")]
        [HttpPost]
        public IHttpActionResult POST(StatisticsOnStudentDTO statistics)
        {
            return Ok();
        }

        //[Route("Get/{}/{}/{}")]
        //[HttpGet]
        //public IHttpActionResult GET(int classCode,int weekNum,int teacherCode)
        //{
        //    return Ok();
        //}


    }
}
