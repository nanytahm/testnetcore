using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreTestInnovar.DataService;
using NetCoreTestInnovar.Models;

namespace NetCoreTestInnovar.BusinessService
{
    public class StudentBusinessService
    {
        private StudentDataService _studentDataService;

        public StudentBusinessService(StudentDataService studentDataService){
            _studentDataService = studentDataService;
        }

        public List<Student> GetStudents(){
            return _studentDataService.GetStudents();
        }

        public Student CreateStudent(Student student){
            return _studentDataService.CreteStudent(student);
        }
        
        /************CONSULTAS*************/
        //older students
        public Student GetOlderStudent(){
             var studentList = _studentDataService.GetStudents();
            var olderStudent = studentList
                             .OrderBy(p=>p.BirthDate).First();
            return olderStudent;
        }
        //student born this month
            public List<Student> GetStudentBornThisMonth(){
             DateTime dNow=DateTime.Now;
             var olderstudentList = _studentDataService.GetStudents()
                                    .Where(p=>p.BirthDate.Month==dNow.Month).ToList();
             return olderstudentList;
            } 
        //student with a word in her name or lastname
            public List<Student> GetStudentsByNameOrLastName(string wordd){
             
             var studentListWithWord = _studentDataService.GetStudents()
                                    .Where(p=>p.Name.Contains(wordd)||(p.LastName.Contains(wordd)))
                                    .ToList();
             return studentListWithWord;
            }
    }
}