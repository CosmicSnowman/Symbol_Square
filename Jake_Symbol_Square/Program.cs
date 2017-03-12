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

            string symbol = Console.ReadLine();

            Console.WriteLine("What size?");

            int size = int.Parse(Console.ReadLine());
            


            //How does a square work
            //same width and height --> same number of characters down as across

            /* for (int j = 1; j < size; j++)
             {
                 for (int i =1; i <= size; i++)
                 {
                     Console.Write(symbol1);
                 }
                 Console.WriteLine();
             }
             */
            //Right Triange
            /* for (int j = 0; j < size; j++)
             {
                for (int i = 1; i <= size - size +1 +j; i++)
                {
                    Console.Write(symbol1);
                }
                Console.WriteLine();
            }
            */
            //Make right side right triangle and equallateral triangle
            //Right Side Right Triangle
            /*  for (int j = 0; j < size; j++)
              {



                  for (int s = 0; s < size - j -1; s++)
                  {

                      Console.Write(" ");
                  }
                      for (int i = 1; i <= size - size + 1 + j; i++)
                      {
                          Console.Write(symbol1);

                      }



                  Console.WriteLine();

              }

              */

            //Equallateral Triangle

            /* for (int j = 0; j < size; j++)
             {



                 for (int s = 0; s < size - j - 1; s++)
                 {



                 nsole.WriteLine();

             }
             */

            /*
            Right Triange

            *     1
            **    2
            ***   3
            ****  4 
            ***** 5
            
            +1 symbol each line for right triangle.
             */

            /* for (int j = 0; j < size; j++)
             {



                 for (int s = 0; s < size - j - 1; s++)
                 {

                     Console.Write(" ");
                 }
                 for (int i = 1; i <= size - size + 1 + j * 2; i++)
                 {
                     Console.Write(symbol1);

                 }


                 Console.WriteLine();

             }
             */








            //I want you to make a rectangle that has a height of 1/2 its width
            //make right triangle



            //Make diamond shape. Baseline number is size

            /*  for (int j = 0; j < size *2; j++)
              {

                  for (int s = 0; s++)
                  {
                  //# of spaces


                  }






              }

              */




            //size will always be odd number.
            //  int wholeNumber;
            //       string word;

            // double realNumber = 0.5f;

            int offset = size - 1;
            
            //
            for (int row = 0; row < size / 2 + 1; row++)
            {
                //Counter starting at 0. Stops when size 
                for (int space = 0; space < size / 2 - row; space++)
                {
                    Console.Write(" ");
                }
                
                //
                for (int col = 0; col < size - offset; col++)
                {
                    Console.Write(symbol);
                }

                //
                offset -= 2;

                Console.WriteLine();
            }
            /*
                        int offset2 = size + 1;
                        for (int row = size / 2; row > 0; row--)
                        {
                            for (int space = 0; space < size / 2 - row + 1; space++)
                            {
                                Console.Write(" ");
                            }

                            for (int col = size - 2;col > size - offset2; size++) 
                                // 3; 3 > 5(add 1 each time) - (5 + 1); each time +1     -1, 0, 1, 2, 3


                                // 5 - 6 Only true once? 
                            {
                                Console.Write(symbol);

                            }

                            Console.WriteLine();
                            offset2 = 2;

                        }


                */


          
                                                                               //collumn = ********
                                                                                          //row =     *
                                                                                           //         *
                                                                                          //          *


            for (int row = size / 2; row > 0; row--)
            {
                for (int space = 0; space < size / 2 - 1; space ++) // ONly worry about front part
                {
                    Console.Write(" ");
                }

                for (int col = size / 2 + 1; col >= 1; col += -2)
                    // 5/2 = 2; 2 = 1 = 3; 3 >= 2 - 2 = 0
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }














            Console.ReadKey();



        }
    }
}
