using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7.Models
{
    public class ParttimeStudent : Student
    {
        public static int MaxNumOfCourses { get; set; }

        public ParttimeStudent(string name) : base(name)
        {

        }
    }
}