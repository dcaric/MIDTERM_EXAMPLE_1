using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAssistent
{
    internal class Task : IComparable<Task>
    {
        public Task(string description, int timeSpent, int difficulty, int priority)
        {
            Description = description;
            TimeSpent = timeSpent;
            Difficulty = difficulty;
            Priority = priority;
        }


        public string Description { get; set; }
        public int TimeSpent { get; set; }
        public int Difficulty { get; set; }
        public int Priority { get; set; }

        public int CompareTo(Task other) => Priority.CompareTo(other.Priority);
       

        public override string ToString()
        => $"Task: {Description}, Time spent: {TimeSpent}h, Difficulty(1-10): {Difficulty}, Priority: {Priority}";


    }
}
