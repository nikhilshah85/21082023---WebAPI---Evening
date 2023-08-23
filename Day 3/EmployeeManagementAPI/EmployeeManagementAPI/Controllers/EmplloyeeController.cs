using EmployeeManagementAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplloyeeController : ControllerBase
    {
        Employees empObj = new Employees(); //this is bad, we should use DI instead

        #region Get Methods
        [HttpGet]
        [Route("/employee/list")]
        public IActionResult GetAllEmployees()
        {
            var empResult = empObj.GetAllEmployees();
            return Ok(empResult);
        }
        [HttpGet]
        [Route("/employee/id/{id}")]
        public IActionResult GetEmpById(int id)
        {
            try
            {
                var emp = empObj.GetEmployeeById(id);
                return Ok(emp);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }

        }
        [HttpGet]
        [Route("/employee/designation/{desig}")]
        public IActionResult GetEmpByDesignation(string desig)
        {
            try
            {
                var emp = empObj.GetEmployeeByDesignation(desig);
                return Ok(emp);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }

        }
        [HttpGet]
        [Route("/employee/dept/{deptno}")]
        public IActionResult GetEmpByDept(int deptno)
        {
            try
            {
                var emp = empObj.GetEmployeesByDept(deptno);
                return Ok(emp);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }

        }
        [HttpGet]
        [Route("/employee/total")]
        public IActionResult GetTotalEmployee()
        {
            var total = empObj.GetTotalEmployees();
            return Ok(total);
        }
        [HttpGet]
        [Route("/employee/totalsalary")]
        public IActionResult GetTotalSalaryPaid()
        {
            var totalSal = empObj.GetTotalSalaryPaid();
            return Ok(totalSal);
        }
        [HttpGet]
        [Route("/employee/permennant/{ispermenant}")]
        public IActionResult GetEmployeeByState(string ispermenant)
        {
            var emp = empObj.getEmployeeByState(ispermenant);
            return Ok(emp);
        }
        #endregion

        #region Post,Put and Delete Methods

        [HttpPost]
        [Route("/employee/add")]
        public IActionResult AddNewEmployee([FromBody] Employees newEmpObj)
        {
            var addMessage = empObj.AddNewEmployee(newEmpObj);
            return Created("", addMessage);
        }

        [HttpPut]
        [Route("/employee/edit")]
        public IActionResult UpdateEmployee([FromBody] Employees changes)
        {
            var updateMessage = empObj.UpdateEmployee(changes);
            return Accepted(updateMessage);
        }

        [HttpDelete]
        [Route("/employee/delete/{empno}")]
        public IActionResult DeleteEmployee(int empno)
        {
            try
            {
                var deleteMessage = empObj.DeleteEmployee(empno);
                return Accepted(deleteMessage);
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }

        #endregion
    }

}











