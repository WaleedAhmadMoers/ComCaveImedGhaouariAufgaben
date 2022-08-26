using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = { 24, 34, 466, 1, 19, 5 };

            for (int index = 0; index < MyArray.Length; index++)
            {
                for (int indexb = 0; indexb < MyArray.Length; indexb++) 
                { 
                if (MyArray[index] < MyArray[indexb])
                    {
                        var  PlaceHolder = MyArray[index];
                        MyArray[index] = MyArray[indexb];
                        MyArray[indexb] = PlaceHolder;

                        var assignedvar = MyArray;
                       
                        foreach (var item in assignedvar)
                        {
                            Console.WriteLine(item);
                        }


                    }
                }

            }


            Console.ReadLine();
        }
    }
}
