using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal static class ExtensionsFormat
    {
        public static string Format(this int value, string format) => $"{value} {format}";
    }
}
