using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Director : Person
    {

        public double Pay { get; set; }
        public Director(string firstName, string lastName, long oib, double pay) : base(firstName, lastName, oib)
        {
            Pay = pay;
        }

        public override string ToString()
        => $"Director: {base.ToString()}, Salary: {Pay}";


    }
}
