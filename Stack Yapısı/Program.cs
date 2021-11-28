using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Yapısı
{


    //Sonsuz döngüde çalışan bir program yazın(dil farketmez, pseudocode da olur). 
    //   Menü aşağıdaki gibi olsun.Yazılacak program tamamen metotlardan oluşacak ve stack için dizi yapısı kullanılacak. 
    //   Dizi (stack) max 5 eleman almalı.
    //   Push
    //   Poppublic
    //   Peek
    //   Clean Stack

    internal class Program
    {
        public int[] dizi = new int[5];
        public int topp = -1;

        static void Main(string[] args)
        {
            Program program = new Program();

            int islem;
            while (true)
            {
                Console.WriteLine("____________________________________________\n Hangi işlemi yapmak istediğinizi seçiniz... \n 1)Push \n 2)Pop \n 3)Peek \n 4)Clean Stack \n 5)Exit\n____________________________________________");
                Console.Write("= ");
                islem = Convert.ToInt32(Console.ReadLine());
                switch (islem)
                {
                    case 1: program.Push(program.topp, program.dizi); break;
                    case 2: program.Pop(program.topp, program.dizi); break;
                    case 3: program.Peek(program.topp, program.dizi); break;
                    case 4: program.CleanStack(program.topp,program.dizi); break;
                    case 5: program.Exit(); break;
                    default: break;


                }



            }
        
        }
        public int Push(int top, int[] stack)
        {
            int veri;
            Console.Write("Stack yapısana eklemek istediğiniz veriyi giriniz: ");
            veri = Convert.ToInt32(Console.ReadLine());
            if (IsFull() ) { Console.WriteLine("Stack is Full!!"); return 1; }
            else { ++top; stack[top] = veri; topp = top; foreach (int i in stack) { Console.WriteLine(i); } return 1; }
        }
        public int Pop(int top, int[] stack)
        {
            if (IsEmpty() ) { Console.WriteLine("Stack is Empty!!"); return 1; }
            else { int temp = stack[top]; stack[top] = 0; --top; topp = top; Console.WriteLine("Deleted value is {0}", temp); foreach (int i in stack) { Console.WriteLine(i); } return 1; }
        }
        public int Peek(int top, int[] stack)
        {
            if (IsEmpty() ) { Console.WriteLine("Stack is Empty!!"); return 1; }
            else { int peek = stack[top]; Console.WriteLine("Peek value of the stack is {0}", peek); return 1; }
        }
        public int CleanStack(int top , int[] stack)
        {
            if (IsEmpty() != false) { Console.WriteLine("Stack is Empty!!"); return 1; }
            else
            {
                for(int i = stack.Length-1; i >= 0; i--)
                {
                    Pop(topp, dizi);
                }
             
                return 1;
            }
        }
        public void Exit()
        {
            Environment.Exit(0);
        }
        public bool IsEmpty()
        {
            if (topp == -1)
            {
                return true;
            }
            else return false;
        }
        public bool IsFull()
        {
            if (topp == dizi.Length - 1)
            {
                return true;
            }
            else return false;
        }
    }
}
