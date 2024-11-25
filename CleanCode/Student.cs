using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class Student : Person, IComparable<Student>
    {


        public enum StudentType
        {
            PartTime = 1,
            Regular
        }

        private readonly int Id;
        private static int counter;

        public StudentType Type { get; set; }

        public Student(string FirstName, string LastName, StudentType type) : base(FirstName, LastName)
        {
            Id = ++counter;
            Type = type;
        }



        public override string ToString()=> $"ID: {Id}, {base.ToString()}, Type: {Type}";

        public int CompareTo(Student other) => -Id.CompareTo(other.Id);
       
    }
}
