using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacultyDataLayer.Repositories;
using FacultyDataLayer.Entities;
namespace FacultyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private FacultyRepository facultyRepository;
        public FacultyController()
        {
            this.facultyRepository = new FacultyRepository();
        }
        [HttpPost,Route("AddFaculty")]
        public IActionResult AddFaculty(Faculty faculty)
        {
            facultyRepository.AddFaculty(faculty);
            return Ok("Facutly Added");
        }
    }
}
