using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Recepcionist : Person
    {
        public double Pay {  get; set; }
        private int OverTime { get; set; }
        public Recepcionist(string firstName, string lastName, long oib, double pay, int overTime) : base(firstName, lastName, oib)
        {
            Pay = pay;
            OverTime = overTime;
        }

        public override string ToString() 
        => $"Recepcionist: {base.ToString()}, Salary: {Pay}, Overtime: {OverTime}";
    }
}
