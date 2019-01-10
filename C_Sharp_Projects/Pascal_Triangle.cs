using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Projects
{
    class Pascal_Traingle
    {
        //static void Main(string[] args)
        //{
        //    //call for the triangle function.
        //    string Input;
        //    int number;
        //    Console.WriteLine("Enter the number: ");
        //    Input = Console.ReadLine();
        //    number = Convert.ToInt32(Input);
        //    theTriangle(number);
            
        //}

        public static void theTriangle(int number)
        {
            int x = 1;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("1");

                }
                Console.WriteLine();
                x++;
            }

        }
    }
}