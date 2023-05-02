using BarApi.Models;
using NetCoreTestInnovar.Models;

namespace NetCoreTestInnovar.DataService
{
    public class CourseDataService
    {
        private Context _context;
        public CourseDataService(Context context){
            _context = context;
        }

        public List<Course> GetCourses(){
            return _context.Course.ToList();
        }

        public Course CreateCourse(Course course){
            _context.Course.Add(course);
            _context.SaveChanges();
            return course;
        }
    }
}