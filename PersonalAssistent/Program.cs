using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAssistent
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task t1 = new Task("zbrajanje",2,8,3);
            Task t2 = new Task("oduzimanje", 4,5,2);
            Task t3 = new Task("mnozenje", 30,  7,1);

            List<Task> tt = new List<Task>
            {
                t1 , t2 , t3    
            };

            Assistent a = new Assistent("Paola" ,"Caric", tt);

            Console.WriteLine(a);
            Console.WriteLine("SORT BY PRIORITY");


            tt.Sort();
            Console.WriteLine(a);


            Console.WriteLine("SORT BY TimeSpent------------------------");
            tt.Sort((x,y)=> x.TimeSpent.CompareTo(y.TimeSpent));
            Console.WriteLine(a);


            Console.WriteLine("SORT BY Difficulty------------------------");
            tt.Sort((x, y) => x.Difficulty.CompareTo(y.Difficulty));
            Console.WriteLine(a);
        }
    }
}
