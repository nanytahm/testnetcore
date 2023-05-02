using Microsoft.AspNetCore.Mvc;
using NetCoreTestInnovar.BusinessService;
using NetCoreTestInnovar.Models;
using Microsoft.EntityFrameworkCore;

namespace NetCoreTestInnovar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private StudentBusinessService _studentBusinessService;

        public StudentController(StudentBusinessService studentBusinessService){
            _studentBusinessService = studentBusinessService;
        }

        [HttpGet("[action]")]
        public List<Student> GetStudents(){
            return _studentBusinessService.GetStudents();
        }
        
        [HttpPost("[action]")]
        public Student CreateStudent(Student student){
            return _studentBusinessService.CreateStudent(student);
        }
        /*******consultas*********/
        //older student
        [HttpGet("[action]")]
        public Student GetOlderStudent(){
            var oldStudentList = _studentBusinessService.GetOlderStudent();

          return oldStudentList;
        }        
        //student born thiw month
        [HttpGet("[action]")]
         public List<Student> GetStudentBornThisMonth(){
            var studentList = _studentBusinessService.GetStudentBornThisMonth();     
            return studentList;
         }
        //student with a word in her name or lastname
        [HttpGet("[action]")]
         public List<Student> GetStudentsByNameOrLastName(string wordd){
            var studentList = _studentBusinessService.GetStudentsByNameOrLastName(wordd);     
            return studentList;
         }

    }
}