using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            double Value1 = UserInput();

            double Value2 = UserInput();

            string result = FinalResult(Value1, Value2);

            Console.WriteLine(result);

            Console.ReadLine();

        }

        //getting user input 
        static double UserInput()
        {
            Console.WriteLine("Enter a number ");
            double GetNumber = Double.Parse(Console.ReadLine());

            return GetNumber;

        }//user input

        
        //comparing the given numbers
        static bool ComparingTheGivenValues(double FirstValue , double SecondValue)
        {



            if (FirstValue > SecondValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//ComparingtheGivenValues



        //getting the Final Result
        static string FinalResult(double FirstValue, double SecondValue)
        {

            //calling function 
            bool GetTheBiggerValue = ComparingTheGivenValues(FirstValue,SecondValue);


            if (GetTheBiggerValue)
            {
                return "the First one is bigger" ;
            }

            else
            {
                return "the Second one is bigger" ;
            }
        }





    }
}