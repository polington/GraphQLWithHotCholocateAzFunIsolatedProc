using HotChocolate.Types;
using IsolatedProcessAzFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedProcessAzFun.Schema
{
   // [ExtendObjectType("Query")]
    public class Query
    {
        private readonly List<CourseType> _studentCourses = new List<CourseType>()
            {
                new CourseType()
                {
                    Id=Guid.NewGuid(),
                    Name="Geometry",
                    Subject = Subject.Maths,
                    Instructor = new InstructorType()
                    {
                        Id= Guid.NewGuid(),
                        FirstName = "Rafa",
                        LastName ="Gonzaliz"
                    },
                    Students = new List<StudentType>
                    {
                        new StudentType
                        {
                           Id= Guid.NewGuid(),
                           FirstName = "Polington",
                           LastName = "Alphonse",
                           GPA = 4.5
                        },
                        new StudentType
                        {
                           Id= Guid.NewGuid(),
                           FirstName = "Ancile",
                           LastName = "Preethi",
                           GPA = 5.5
                        }
                    }
                },
                new CourseType()
                {
                    Id=Guid.NewGuid(),
                    Name="Biology",
                    Subject = Subject.Science,
                    Instructor = new InstructorType()
                    {
                        Id= Guid.NewGuid(),
                        FirstName = "Jeshrun",
                        LastName ="Polington"
                    },
                    Students = new List<StudentType>
                    {
                        new StudentType
                        {
                           Id= Guid.NewGuid(),
                           FirstName = "Jiannah",
                           LastName = "Polington",
                           GPA = 4.5
                        },
                        new StudentType
                        {
                           Id= Guid.NewGuid(),
                           FirstName = "Raju",
                           LastName = "Preethi",
                           GPA = 5.5
                        }
                    }
                }
            };

        public IEnumerable<CourseType> GetCourses()
        {
            return _studentCourses;
        }

        public CourseType GetCourseById(Guid id)
        {
            return _studentCourses.FirstOrDefault(x => x.Id.Equals(id));
        }

        //[GraphQLDeprecated("This Query is deprecated.")]
        public string Instructions => "You're accessing Instruction for student courses!";


    }
}
