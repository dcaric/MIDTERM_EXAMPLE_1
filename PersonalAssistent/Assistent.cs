using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAssistent
{
    internal class Assistent
    {
        public Assistent(string firstName, string lastName, List<Task> tasks)
        {
            FirstName = firstName;
            LastName = lastName;
            Tasks = tasks;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        List<Task> Tasks = new List<Task>();


        public override string ToString()
        {
            string taskList = string.Join("\n ", Tasks);

            return $"First name: {FirstName}, Surname: {LastName}, \n Tasks: {taskList}";
        }


    }
}
