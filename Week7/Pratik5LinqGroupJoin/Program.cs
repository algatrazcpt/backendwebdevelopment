namespace Pratik5LinqGroupJoin
{

    public class Student
    {
        public int studentId;
        public string studentName;
        public int courseId;
    }
    public class Course
    {
        public int courseId;
        public string courseName;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>
            {
                new Student { studentId = 1, studentName = "Ali", courseId = 101 },
                new Student { studentId = 2, studentName = "Ayşe", courseId = 102 },
                new Student { studentId = 3, studentName = "Mehmet", courseId = 103 },
                new Student { studentId = 4, studentName = "Fatma", courseId = 104 },
                new Student { studentId = 6, studentName = "Ahmet", courseId = 105 },
                new Student { studentId = 7, studentName = "Ahmet", courseId = 120 },
                new Student { studentId = 3, studentName = "Mehmet", courseId = 105 }
            };
            List<Course> coursesList = new List<Course>
            {
                new Course { courseId = 101, courseName = "Matematik" },
                new Course { courseId = 102, courseName = "Fizik" },
                new Course { courseId = 103, courseName = "Kimya" },
                new Course { courseId = 104, courseName = "Biyoloji" },
                new Course { courseId = 105, courseName = "Tarih" }
            };

            foreach(var values in coursesList.Join(studentsList, student => student.courseId, courses => courses.courseId, (courses,student ) => new {courseName=courses.courseName,studentName=student.studentName}))
            {
                Console.WriteLine("Kurs adı:"+values.courseName+"\t Ögrenci adı:"+values.studentName);
            }


        }
    }
}
