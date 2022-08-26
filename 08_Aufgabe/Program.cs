using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {

            int ArraySize = GettingArraySize();
            int[] myArray = CreatingArray(ArraySize);


            //getting Values From User 
            for (int index = 0, index < ArraySize , index++) {

                Console.WriteLine("Please Enter The\t" + index + "\tValue: ");
                string GetValue = Console.ReadLine();
                int PlaceHolder = Convert.ToInt32(GetValue);
                myArray[index] = PlaceHolder;
                
            }
            //printing out the array content
            foreach (var item in myArray)
                Console.WriteLine(item);

            Console.ReadLine();
        }//Main 


        // lesen die Größe vom Benutzer ein
        static int GettingArraySize()
        {
            Console.Write("How long you want your array to be ? ");
            string GetSize = Console.ReadLine();
            int sSize = Convert.ToInt32(GetSize);
            return sSize;
        }


        //Erzeugen ein Array  
        static int[] CreatingArray(int ArraySize)
        {

            int[] MyArray = new int[ArraySize];
            return MyArray;
        }


 











    }
}
