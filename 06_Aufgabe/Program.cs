using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Aufgabe
{
    class Program
    {
        static void Main()
        {

            for (int index = 0; index < 10; index++)
            {
                int N1 = GettingUserNumber();
                string Op = GettingUserCalculationType();
                int N2 = GettingUserNumber();
                Console.WriteLine(FinalResult(N1, Op, N2));
                Console.ReadLine();
            }
        }//Main

        //Es dürfen nur gültige Zahlenwerte gespeichert werden,
        //sonst bekommt man ein 0 als ruckgabe wert
        static int FinalResult(int N1, string Op, int N2)
        {
            if (Op == "+")
            {
                return Addition(N1, N2);
            }
            else if (Op == "-")
            {
                return Subtraction(N1, N2);
            }
            else if (Op == "*")
            {
                return Multiplication(N1, N2);
            }
            else if (Op == "/")
            {
                return Division(N1, N2);
            }
            //sonst bekommt man ein 0 als ruckgabe wert
            else
            {
                return 0;
            }

        }//FinalResult

        //Was soll mit den eingelesenen Zahlen passieren
        static string GettingUserCalculationType()
    {
        Console.WriteLine("Please Enter  your Operation Methode : ");
        string Operation = Console.ReadLine();
        return Operation;
    }//GettingUserCalculationType


        //Zahlen vom Benutzer einlesen
        static int GettingUserNumber()
    {
        Console.WriteLine("Please Enter  your  number : ");
        string GettingUserInput = Console.ReadLine();
        int Number = int.Parse(GettingUserInput);
        return Number;
    }//GettingUserNumber


    static int Addition(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    //Addition 
    static int Subtraction(int FirstNumber, int SecondNumber)
    {
        return FirstNumber - SecondNumber;
    }
    //Subtraction
    static int Division(int FirstNumber, int SecondNumber)
    {
        return FirstNumber / SecondNumber;
    }
    //Division

    static int Multiplication(int FirstNumber, int SecondNumber)
    {
        return FirstNumber * SecondNumber;
    }//Multiplication


}
}

