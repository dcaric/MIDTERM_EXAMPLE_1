using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class Course : IsSigned
    {
      

        public int code { get; set; }
        public string name { get; set; }

        private int points;
        public int Ects {

            get => points;

            set
            {
                if (value < 20 || value > 30)
                {
                    throw new Exception("Ects point are between 20-30");
                }
                points = value;

            }
        }


        public bool Approved { get; set; }

        public bool Sign() => Approved = true;

        public override string ToString() => $"Name: {name}, Code: {code}, {Ects.Format("ects")} Signed: {(Approved ? "yes" : "no")} ";
      

    }
}
