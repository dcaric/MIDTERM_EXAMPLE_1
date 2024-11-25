using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Room
    {
        public Room(int number, double price, RoomType type)
        {
            Number = number;
            Price = price;
            Type = type;
        }

        public enum RoomType
        {
            OneBed = 1,
            TwoBed,
            FamilyRoom
        }

        public int Number { get; set; }
        public double Price { get; set; }
        public RoomType Type { get; set; }  

        public override string ToString()
        => $"Room number: {Number}, price: {Price.Format("kn")}, type: {Type}";

    }
}
