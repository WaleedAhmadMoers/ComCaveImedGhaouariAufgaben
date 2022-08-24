using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Uebung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling UserInput Function To get The First number
            double myNumber1 = UserInput();

            //Calling UserInput Function To get The First number
            double myNumber2 = UserInput();
             
            Console.WriteLine(ResultOfEquation(myNumber1 , myNumber2));
            Console.ReadLine();
        }




        //getting user input 
        static double UserInput()
        {
            Console.WriteLine("Enter a number ");
            double GetNumber = Double.Parse(Console.ReadLine());

            return GetNumber;

        }
        //solving the Equation 
        static double AddNumber(double Number1 , double Number2)
        {
            return Number1 + Number2;

        }

        //getting result after adding the numbers
        static double ResultOfEquation(double Number1, double Number2)
        {
            double result = AddNumber(Number1, Number2);
            return result;
        }
    }
}
