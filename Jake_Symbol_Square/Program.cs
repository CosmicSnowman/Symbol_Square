using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake_Symbol_Square
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What symbol would you like?");

            string symbol1 = Console.ReadLine();

            Console.WriteLine("What size?");

            int size = int.Parse(Console.ReadLine());


            //How does a square work
            //same width and height --> same number of characters down as across

            for (int j = 1; j < size; j++)
            {
                for (int i =1; i <= size; i++)
                {
                    Console.Write(symbol1);
                }
                Console.WriteLine();
            }
            
            // 


            //I want you to make a rectangle that has a height of 1/2 its width
            //make right triangle
            

            Console.ReadKey();


        }
    }
}
