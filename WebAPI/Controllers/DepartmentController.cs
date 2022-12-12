using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        private DataContext _context;
        public DepartmentController(DataContext context)
        {
            _context = context;
        }
        public HttpResponseMessage Get()
        {
            var data = _context.Departments.ToList();
            Console.WriteLine(data);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
