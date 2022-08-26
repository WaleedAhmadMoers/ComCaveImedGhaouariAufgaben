using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {

            int MyNumber1 = Input();
            int MyNumber2 = Input();
            int Result = Calculate(MyNumber1, MyNumber2);            
            Console.Write(OutPut(Result));

            Console.ReadLine();
        }
        //Methode mit dem Namen „eingabe“.

        static int Input()
        {
            Console.Write("Number>>>>>");
            //eine Zahl von dem Benutzer einliest
            int MyNumber = int.Parse(Console.ReadLine());
            //und eine Integer Zahl zurückgibt
            return MyNumber;
        }

        //Methode mit dem Namen „berechne“, die zwei Zahlen als Parameter aufnimmt,
       
        static int Calculate(int MyNumber1 , int MyNumber2)
        {
            //diese Multipliziert und als Integer zurückgibt
            return MyNumber1 * MyNumber2;

        }
        //eine Methode mit dem Namen „ausgabe“die eine Zahl als Parameter

        static int OutPut(int Result)
        {

            return Result;

        }




    }
}
