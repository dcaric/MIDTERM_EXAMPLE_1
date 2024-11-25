using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Worker : Person
    {

        public Worker(string firstName, string lastName, long oib) : base(firstName, lastName, oib)
        {
        }

        public override string ToString()
        => $"Worker: {base.ToString()}";



    }
}
