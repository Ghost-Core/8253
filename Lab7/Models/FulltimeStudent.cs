using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7.Models
{
    public class FulltimeStudent : Student
    {
        public static int MaxWeeklyHours { get; set; }

        public FulltimeStudent(string name) : base(name)
        {

        }
    }
}