using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstAPI.Models;
namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student(){StudentId=1,StudentName="Rohan",Age=10},
             new Student(){StudentId=2,StudentName="Charan",Age=10}
        };
        [HttpGet, Route("GetAllStudents")]
        public IActionResult GetAll()
        {
            return StatusCode(200, Students); //students details are send in json form
        }
        [HttpGet, Route("GetStudentById/{id}")]
        public IActionResult Get(int id)
        {
            Student student = Students.SingleOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                return StatusCode(200, student);
            }
            else
            {
                return StatusCode(404, "Invalid Id");
            }
        }
        [HttpPost, Route("AddStudent")]
       public IActionResult Add(Student student)
        {
            Students.Add(student); //add student to list
            return StatusCode(200, "Student Added");
        }
        //[HttpGet, Route("GetStudentById/{id}")]
        //public Student Get(int id)
        //{
        //    Student student = Students.SingleOrDefault(s => s.StudentId == id);
        //    return student;
            
        //}
    }
}
