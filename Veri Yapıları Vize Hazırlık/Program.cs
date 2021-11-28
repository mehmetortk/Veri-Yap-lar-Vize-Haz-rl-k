using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Vize_Hazırlık
{//faktöriyel programı recursive ile
    internal class Program
    { public int toplam = 0;
        static void Main(string[] args)
        {

            Console.WriteLine(faktoriyel(6));
            Console.ReadKey();
        }


        static int faktoriyel(int data)
        {
            if (data == 1)
                return 1;
            else return data * faktoriyel(data - 1);
        }
        


    }
}
