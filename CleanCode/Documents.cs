using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class Documents : IsSigned
    {

        public string Title { get; set; }

        public string Text { get; set; }
        public bool Approved { get; set; }

        public bool Sign() => Approved = true;

        public override string ToString() => $"Title: {Title}, Text: {Text}, Signed: {(Approved ? "yes" : "no")}";



    }
}
