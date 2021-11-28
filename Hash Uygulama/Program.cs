using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Uygulama
{
  
    internal class Program
    {
        public int deger;
        public int[] dizi = new int[10];
        static void Main(string[] args)
        { Program program = new Program(); 
        program.HashFunction();
            Console.ReadKey();
        }

    public void HashFunction()
    {
         
            for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write("Lütfen " + (i + 1) + ". değeri giriniz: ");
            deger = int.Parse(Console.ReadLine());
            dizi[deger % dizi.Length] = deger;

        }
        foreach (int fatihgöttenyiyor in dizi)
        {
            Console.WriteLine(fatihgöttenyiyor);
        }
    }




}
}
