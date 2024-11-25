using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Director d = new Director("Paola","Caric",099959999995, 78.0);

            Worker w = new Worker("Iva","Ivic", 099919999991);
            Worker w2 = new Worker("Sara", "Saric", 099929999992);
            Worker w3 = new Worker("Luka", "Lukic", 099939999993);


            Room r1 = new Room(1,444.4,Room.RoomType.OneBed);
            Room r2 = new Room(2, 66, Room.RoomType.TwoBed);
            Room r3= new Room(3, 500, Room.RoomType.FamilyRoom);

            Maid m = new Maid("Mia", "Mijic", 099949999994, 99.99,10);

            Recepcionist r = new Recepcionist("Dora", "Doric", 099969999996, 666.6, 999);

            List<Worker> w1 = new List<Worker>
            {
                w,w2,w3
            };

            List<Room> rr = new List<Room>
            {
                r1,r2,r3
            };


            Hotel hotel = new Hotel(5,"Split",d,w1,rr);


            Console.WriteLine(hotel);
        }
    }
}
