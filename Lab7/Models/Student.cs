using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7.Models
{
    public class Student
    {
        public readonly int Id;

        public readonly string Name;

        public Student(string name)
        {
            Name = name;
            Random rand = new Random();
            Id = rand.Next(900000, 999999);
        }
    }
}