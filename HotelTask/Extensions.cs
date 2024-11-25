using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HotelTask
{
    internal static class Extensions
    {

        public static string Format(this double value, string format) => $"{value} {format}";
    }
}
