using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaziDiziler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("How many names do you want to sort?");
            //int number = int.Parse(Console.ReadLine());
            //string[] name = new string[number];

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.Write($"Enter {i + 1} . Name:> ");
            //    name[i] = Console.ReadLine(); //
            //}
            //Array.Sort(name);
            //Console.WriteLine("sorted names:");
            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine($"{i + 1}-{name[i]}");
            //}

            //Kullanıcıdan sayı istediği sayıda rastgele sayıyı sıralı bir şekilde yazdır
            Random rnd = new Random();
            Console.Write("Enter a number> ");
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            int num = 0;
            for(int i=0; i<count; i++)
            {
             
                numbers[i]= rnd.Next(0,100);
                if (numbers[i] == numbers[i])
                {
                    while (num==i)
                    {
                        numbers[i] = rnd.Next(0, 100);
                        if(numbers[i]!=numbers[i])
                        {
                            numbers[i] = numbers[i];
                            break;
                        }
                        num++;
                    }
                  
                }
            }
          
            Array.Sort(numbers);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{ i+1}-{numbers[i] }");
            }
           



            Console.ReadKey();
        }
    }
}
