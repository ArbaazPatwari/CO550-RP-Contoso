using ASP_Razor_Contoso.Models;

namespace ASP_Razor_Contoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Arbaaz",LastName="Patwari",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Mohammed",LastName="Loqman",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Stefan",LastName="Allen",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Akes",LastName="Ali",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Ben",LastName="Thompson",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Alfred",LastName="Holmes",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Bilal",LastName="Rahman",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Cassandra",LastName="Yareli",EnrollmentDate=DateTime.Parse("2022-09-26")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Software Engineering",Credits=120},
                new Course{CourseID=4022,Title="Computing and Web Development",Credits=120},
                new Course{CourseID=4041,Title="Cyber Security",Credits=120},
                new Course{CourseID=1045,Title="Games Development",Credits=120},
                new Course{CourseID=3141,Title="Data Science",Credits=120},
                new Course{CourseID=2021,Title="Business Management and Information Technology",Credits=120},
                new Course{CourseID=2042,Title="Computing",Credits=120}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
