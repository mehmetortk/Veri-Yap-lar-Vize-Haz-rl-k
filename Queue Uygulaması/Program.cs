using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Uygulaması
{
    //   Sonsuz döngüde çalışan bir program yazın(dil farketmez, pseudocode da olur).
    //   Menü aşağıdaki gibi olsun.Yazılacak program tamamen metotlardan oluşacak ve queue için dizi yapısı kullanılacak.
    //   Dizi (queue) max 5 eleman almalı. [Doğrusal kuyruk - kaydırmasız]
    //   Enqueue
    //   Dequeue
    //   Peek
    //   Clean Queue

    internal class Program
    {
        public int count = 0;
        public int rear = -1, front = -1;
        public int[] dizi= new int[5];
        static void Main(string[] args)
        {
            Program program = new Program();

            int islem;
            while (true)
            {
                Console.WriteLine("____________________________________________\n Hangi işlemi yapmak istediğinizi seçiniz... \n 1)Enqueue \n 2)Dequeue \n 3)Peek \n 4)Clean Queue \n 5)Exit\n____________________________________________");
                Console.Write("= ");
                islem = Convert.ToInt32(Console.ReadLine());
                switch (islem)
                {
                    case 1: program.Enqueue(program.rear, program.dizi); break;
                    case 2: program.Dequeue(program.front, program.dizi); break;
                    case 3: program.Peek(program.rear, program.dizi); break;
                    case 4: program.CleanQueue(program.front, program.dizi); break;
                    case 5: program.Exit(); break;
                    default: break;


                }

            }

        }

        public int Enqueue(int rearr, int[] queue)
        {
            
            int veri;
            Console.Write("Queueya ekleyeceğiniz değeri giriniz: ");
            veri = int.Parse(Console.ReadLine());
            count++;
            if(front==-1) front = 0;
            if (IsFull()) { Console.WriteLine("Queue is full!!!"); return 1; }
            else {
                ++rearr;  queue[rearr] = veri; rear = rearr; foreach (int i in queue) { Console.WriteLine(i); }
                return 1;
            }

        }
        public int Dequeue(int frontt,int[]queue)
        {
            
        }
        public int Peek(int rearr, int[] queue)
        {
            return 1;
        }
        public int CleanQueue(int frontt, int[] queue)
        {
            return 1;
        }
        public int Exit()
        {
            return 1;
        }
        public bool IsFull()
        {
            if(rear==dizi.Length-1||count==dizi.Length) return true;
            else return false;
        }
        public bool IsEmpty()
        {
            if (count == 0 || rear == -1) return true;
            else return false;
        }

    }
}
