using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CleanCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("milica", "krmpotic", Student.StudentType.Regular);
            Student s2 = new Student("daniel", "bele", Student.StudentType.PartTime);
            Student s3 = new Student("john", "wayne", Student.StudentType.PartTime);

            List<Student> list = new List<Student>
            {
                s1, s2, s3
            };

            Console.WriteLine("NO SORTING ----------------------------------------------------");
            list.ForEach(Console.WriteLine);

            Console.WriteLine(" DESC BY ID ----------------------------------------------------");
            list.Sort();
            list.ForEach(Console.WriteLine);

            Console.WriteLine(" ASC BY LASTNAME ----------------------------------------------------");
            list.Sort((x,y)=> x.Surname.CompareTo(y.Surname));
            list.ForEach(Console.WriteLine);

            Course c1 = new Course();

            Course c = new Course
            {
                code = 1,
                Ects = 30,
                name = "OOP"
            };

            Console.WriteLine("COURSE(NOT SIGNED)-------------------------------------");

            Console.WriteLine(c);


            Console.WriteLine("TACHER AND ASSISTANT FOR OOP-----------------------------------");
            Teacher proff = new Teacher("Ivan", "Bele", c);
            Teacher asiss = new Teacher("Martin", "Matic", c);

            Console.WriteLine(proff);
            Console.WriteLine(asiss);

            Console.WriteLine("Dean ----------------------------------------------");
            Dean dean = new Dean("Dean", "Martin", "Da dean");
            Console.WriteLine(dean);

            List<Person> persons = new List<Person>
            {
                s1,
                s2,
                s3,
                proff,
                asiss,
                dean
            };

            Console.WriteLine($"All people: {persons.Count}");


            Console.WriteLine("Document, unsigned--------------------------");
            Documents documents = new Documents
            {
                Title = "Title",
                Text = "Text",

            };

            Console.WriteLine(documents);


            Console.WriteLine("SIGNED BY DEAN----------------------------------------------------");
            List<IsSigned> s = new List<IsSigned>
           {
               c,
               documents
           };


            s.ForEach(dean.GiveSign);
            s.ForEach(Console.WriteLine);

        }
    }
}
