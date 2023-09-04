using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace di_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {


        // Employee empObj = new Employee(); //have u written code to destroy ???
        //use DI here instead


        Employee _empObj;

        public EmployeeController(Employee _empObjREF)
        {
            _empObj = _empObjREF;
        }


        [HttpGet]
        [Route("/employee")]
        public IActionResult GetAllEmployees()
        {
            var data = _empObj.GetAllEmployees();
            return Ok(data);
        }
    }
}
