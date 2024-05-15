using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedProcessAzFun.Models
{
    public enum Subject
    {
        Maths,
        Science,
        History
    }
    public class CourseType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<StudentType> Students { get; set; }
        public Subject Subject { get; set; }

        public InstructorType Instructor { get; set; }
    }

    public class InstructorType
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
    }
}