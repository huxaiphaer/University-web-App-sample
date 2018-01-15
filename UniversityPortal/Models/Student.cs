using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityPortal.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }sss
    }
}