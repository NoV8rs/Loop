using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Double Nested Loops");
            Console.WriteLine("A loop without a loop");
            Console.WriteLine("----");
            Console.WriteLine();

            //int start = 0; Can use this, usally might have this
            //int end = 9;

            //int numDigits = 2; //binary
            //int numDigits = 3; //trinay
            //int numDigits = 8; // octal
            //int numDigits = 10; // decimal
            //int numDigits = 16; // hexidecimal


            //for(int i = 0; i <= numDigits - 1; i++)// i = 0..9 (10)
            {    
                //for(int j = 0; j <= numDigits - 1; j++)// 
                {
                    //for(int k = 0 ; k <= numDigits - 1 ; k++)
                    {
                       //Console.WriteLine(i + "" + j + "" + k);
                    }
                }
            }

            //Print the map for the Player
            int width = 20;
            int height = 10;
            for (int x = 0; x <= width - 1; x++)
            {
                for (int y = 0; y <= height - 1; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
