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

        [Route("class1/{classCode}")]
        [HttpGet]
        public IHttpActionResult Class1(int classCode)
        {
            List<StatisticDiagram> d = new List<StatisticDiagram>();
            d.Add(BL.StatisticsOnStudentBL.ErrorsForClassCategory(classCode));
            d.Add(BL.StatisticsOnStudentBL.ErrorsForClassWeek(classCode));

            return Ok(d);
        }
        [Route("student/{studentCode}")]
        [HttpGet]
        public IHttpActionResult Student(int studentCode)
        {
            List<StatisticDiagram> d = new List<StatisticDiagram>();
            d.Add(BL.StatisticsOnStudentBL.ErrorsForStudentCategory(studentCode));
            d.Add(BL.StatisticsOnStudentBL.ErrorsForStudentWeek(studentCode));

            return Ok(d);
        }


        //[Route("Get/{}/{}/{}")]
        //[HttpGet]
        //public IHttpActionResult GET(int classCode,int weekNum,int teacherCode)
        //{
        //    return Ok();
        //}


    }
}
