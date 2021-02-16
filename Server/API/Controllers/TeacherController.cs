using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [RoutePrefix("api/teacher")]
    [EnableCors("*", "*", "*")]

    public class TeacherController : ApiController
    {
        [Route("GetClassListForTeacher/{teacherId}")]
        public IHttpActionResult GetClassListForTeacher(int teacherId)
        {
            return Ok(BL.TeacherBL.GetClassListForTeacher(teacherId));
        }

        [HttpGet]
        [Route("GetStudentListForTeacher/{teacherId}/{classId}")]
        public IHttpActionResult GetStudentListForTeacher(int teacherId, int classId)
        {
            return Ok(BL.TeacherBL.GetStudentListForTeacher(teacherId, classId));
        }



        [Route("GetCategoryListForClass/{classId}")]
        public IHttpActionResult GetCategoryListForClass(int classId)
        {
            return Ok(BL.TeacherBL.GetCategoryListForClass(classId));
        }

        [Route("GetWeekListForClass/{classId}")]
        public IHttpActionResult GetWeekListForClass(int classId)
        {
            return Ok(BL.TeacherBL.GetWeekListForClass(classId));
        }

    }
}
