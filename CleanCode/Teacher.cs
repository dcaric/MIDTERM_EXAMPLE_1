using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class Teacher : Person
    {
        public Course Course { get; set; }

        public Teacher(string name, string surname, Course course) : base(name, surname)
        {
            Course = course;
        }


        public override string ToString() => $"{base.ToString()}, Course: {Course}";
       
    }
}
