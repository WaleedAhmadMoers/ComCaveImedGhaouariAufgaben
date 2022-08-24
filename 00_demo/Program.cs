using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an integer 
            int number = 0;
            //Call the function
            PrintNumber(number);

            //don't close the console after printing the number 
            Console.ReadLine();
            
        }
        //Creating Function to return The Number 
        static int MyNumber()
        {
            return 0;
        }
        //Function To print the number which declared at Mynumber Function 
        static void PrintNumber(int Number)
        {
            Console.WriteLine(Number);
        }
    }
}
