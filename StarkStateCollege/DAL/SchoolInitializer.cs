using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StarkStateCollege.Models;//use your project name here

namespace StarkStateCollege.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
               new Student{FirstName="Carson",MiddleName="Joe",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
               new Student{FirstName="Meredith",MiddleName="John",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
               new Student{FirstName="Arturo",MiddleName="Arto",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
               new Student{FirstName="Gytis",MiddleName="Godo",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
               new Student{FirstName="Yan",MiddleName="Mu",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
               new Student{FirstName="Peggy",MiddleName="Sue",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
               new Student{FirstName="Laura",MiddleName="Lynn",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
               new Student{FirstName="Nino",MiddleName="Jack",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3,},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
                new Course{CourseID=1045,Title="Calculus",Credits=4,},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
                new Course{CourseID=2021,Title="Composition",Credits=3,},
                new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050,},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }

    }
}