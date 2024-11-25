using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private long oib;

        protected Person(string firstName, string lastName, long oib)
        {
            FirstName = firstName;
            LastName = lastName;
            Oib = oib;
        }


        public long Oib 
        {
            get => oib;
            set
            {
                if(value.ToString().Length != 11 && value.ToString()[4] == value.ToString()[10])
                {
                    throw new Exception("Oib mora imati 11 znakova, mora poceti s o (nula), a peti broj mora biti jednak posljednjem broju.");
                }
                oib = value;
            }        
        }

        public override bool Equals(object obj) => obj is Person other && oib == other.oib;

        public override string ToString()
        => $"Name: {FirstName}, Surname:  {LastName}, OIB: {oib}";




    }
}
