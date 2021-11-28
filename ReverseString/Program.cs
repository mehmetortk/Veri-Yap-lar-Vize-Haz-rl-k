using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(ReverseString("Emir Nabıyon LA"));
            Console.ReadKey();
        }
        static string ReverseString(string data)
        {
            if (data == null || data.Length < 1)
                return data;
            else return ReverseString(data.Substring(1))+data[0];
        }
    }
}
