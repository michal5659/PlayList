using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*","*","*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [Route("RegisterTeacher")]
        public IHttpActionResult RegisterTeacher(UserDTO teacher)
        {
            int teacherId = BL.UserBL.RegisterTeacher(teacher);
            return Ok(teacherId);
        }

        [Route("RegisterStudent")]
        public IHttpActionResult RegisterStudent(UserDTO student)
        {
            int studentId = BL.UserBL.RegisterStudent(student);
            return Ok(studentId);
        }

        [Route("uploadStudentsDetailes"),HttpPost]
        public IHttpActionResult UploadStudentsDetailes()
        {
            HttpPostedFile fileToSave = HttpContext.Current.Request.Files[0];
            string path = HostingEnvironment.MapPath("~/ExcelFiles/students.xlsx");
            fileToSave.SaveAs(path);
            BL.ExtractExcelData.SaveStudents(path);
            return Ok();
        }

        [Route("Login"), HttpPost]
        public IHttpActionResult Login([FromBody]UserDTO user)
        {
            UserDTO u = BL.UserBL.Login(user.ID, user.Password);
            return Ok(u);

        }

        [Route("GetUserById/{userCode}")]
        public IHttpActionResult GetUserById(string userCode)
        {
            //UserDTO u = UserBL.GetUserById(teacherCode);
            return Ok(UserBL.GetUserById(userCode));
        }
    }
}
