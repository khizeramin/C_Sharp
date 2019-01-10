using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Projects
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello World");
        //    triangle_A();
        //    Console.WriteLine("..............");
        //    Console.WriteLine();
        //    triangle_B();
        //    Console.ReadKey();
        //}
        public static void triangle_A()
        {
            int x = 1;
            for (int i =0; i < 20; i++)
            {
                for (int j=0; j < x; j++)
                {   
                    Console.Write("*");
                    
                }
                Console.WriteLine();
                x++;
            }
            
        }
        public static void triangle_B()
        {
            int x = 20;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                x--;
            }

        }
    }
}
