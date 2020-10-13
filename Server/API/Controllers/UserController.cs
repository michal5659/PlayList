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
    }
}
