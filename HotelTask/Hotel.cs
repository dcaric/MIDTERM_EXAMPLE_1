using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Hotel 
    {
        public Hotel(int stars, string address, Director director, List<Worker> workers, List<Room> rooms)
        {
            Stars = stars;
            Address = address;
            this.director = director;
            this.workers = workers;
            this.rooms = rooms;
        }

        public int Stars { get; set; }
        public string Address { get; set; }
        public Director director { get; set; }


        List<Worker> workers = new List<Worker>();
        List<Room> rooms = new List<Room>();


        public override string ToString()
        {
            string roomsList = string.Join("\n ", rooms);
            string workersList = string.Join("\n", workers);


            return $"Stars: {Stars},\n Address: {Address},\n Director {director}, " +
                $"\n Rooms:{roomsList}, \n Workers: {workersList}";
        }        


               
          

    }
}
