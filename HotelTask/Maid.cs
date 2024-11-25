using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Maid : Person
    {
        public double Pay { get; set; }
        public int YearsWorked { get; set; }
        public Maid(string firstName, string lastName, long oib, double pay, int yearsWorked) : base(firstName, lastName, oib)
        {
            Pay = pay;
            YearsWorked = yearsWorked;
        }

        public override string ToString()
        => $"Maid: {base.ToString()}, Salary: {Pay}, Years worked: {YearsWorked}";
    }
}
