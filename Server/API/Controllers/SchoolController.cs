using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [RoutePrefix("api/school")]
   [EnableCors("*","*","*")]
    public class SchoolController : ApiController
    {
        public IHttpActionResult GetSchoolList()
        {
            return Ok(BL.SchoolBL.GetSchoolList());
        }
    }
}
