using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Projects
{
    class testGUI
    {
        static void Main(string[] args)
        {
            int retVal = 0;
            string input1 = "";
            string input2 = "";
            int number1 = 0;
            int number2 = 0;
            string character = "";
            Console.WriteLine("You just give 2 numbers here: ");
            Console.Write("");
            Console.WriteLine("Number 1: ");
            input1 = Console.ReadLine();
            number1 = Convert.ToInt32(input1);
           
            Console.WriteLine("\n");
            Console.WriteLine("Operation ? :");
            character = Console.ReadLine();
            Console.WriteLine("\n");
            
            Console.WriteLine("\n");
            Console.WriteLine("Number 2: ");
            input2 = Console.ReadLine();
            number2 = Convert.ToInt32(input2);
            Console.WriteLine("\n");

             
            //Function call...
            retVal = Calculations(number1, number2, character);

            Console.WriteLine("The answer is: ");
            Console.WriteLine(retVal);
             
        }
        //Function definitions follow:

        public static int Calculations(int number1, int number2, string character)
        {
           int retVal = 0;
           int Multiplications(int firstNr, int secondNr)
            {
                return firstNr * secondNr;

            }
            int Division(int firstNr, int secondNr)
            {
                return firstNr / secondNr;

            }
            int Addition(int firstNr, int secondNr)
            {
                return firstNr + secondNr;

            }
            int Subtraction(int firstNr, int secondNr)
            {
                return firstNr - secondNr;

            }
            Console.WriteLine("Calculating...");

            switch(character)

            {
                case "*":
                    retVal = Multiplications(number1, number2);
                    break;
                case "/":
                    retVal = Division(number1, number2);
                    break;
                case "+":
                    retVal = Addition(number1, number2);
                    break;
                case "-":
                    retVal = Subtraction(number1, number2);
                    break;
                default:
                    Console.WriteLine("RUN!!!");
                    break;
            }
            
            return retVal;
        }










    }
}