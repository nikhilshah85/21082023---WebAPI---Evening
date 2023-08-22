using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace technologyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class technologyController : ControllerBase
    {
        #region Data
        static List<string> techList = new List<string>()
       {
                "ASP.Net MVC",
                "Angular",
                "React",
                "ASP.Net WebAPI",
                "Azure",
                "GCP",
                "SQL Server"
       };
        #endregion

        #region Get Methods

        [HttpGet]
        [Route("/technology/list")]
        public IActionResult GetAllTechnologies()
        {
            return Ok(techList);
        }

        [HttpGet]
        [Route("/technology/find/{idx}")]
        public IActionResult GetTechnologyByIndex(int idx)
        {
            if (idx > techList.Count)
            {
                return NotFound("Sorry No technology found at this position");
            }
            var tech = techList[idx];
            return Ok(tech);
        }

        [HttpGet]
        [Route("/technology/total")]
        public IActionResult GetTotalTechnologies()
        {
            return Ok(techList.Count);
        }
        
        [HttpGet]
        [Route("/technology/search/{characters}")]
        public IActionResult SearchTechnology(string characters)
        {
            var tech = techList.FindAll(t => t.StartsWith(characters));
            return Ok(tech);
        }

        #endregion

        [HttpPost]
        [Route("/technology/add/{newTechName}")]
        public IActionResult AddNewTechnology(string newTechName)
        {
            techList.Add(newTechName);
            return Created("", "Technology Add to list");
        }

        [HttpDelete]
        [Route("/technology/delete/{idx}")]
        public IActionResult DeleteTechnology(int idx)
        {
            techList.RemoveAt(idx);
            return Accepted("Your request to delete the technology is accepted");
        }
        [HttpPut]
        [Route("/technology/edit/{idx}/{newName}")]
        public IActionResult Updatetechnology(int idx, string newName)
        {
            techList[idx] = newName;
            return Accepted("Technology name changed successfully");
        }
    }
}







