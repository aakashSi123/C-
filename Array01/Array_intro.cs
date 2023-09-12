using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Array01
{

    public class Array_intro
    {
        static void Array_data(int iKnowTheLengh)
        {
            for (int i = 0; i < iKnowTheLengh; i++)
            {
                System.Console.Write(i + " , ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char Yes_No;
            int input;
            System.Console.WriteLine("This is the output");
            int[] array;
            array = new int[] { 1, 2, 3, 4, 5, 6, 7 };


            int iKnowTheLengh = array.Length;
            array[3] = 40; // overriding the value of element in memory index 3 i.e. 4 to 40
            Console.WriteLine($"The output of the array data  is {array[3] + 1}");
            Array_data(iKnowTheLengh);

            Console.WriteLine("Hey buddy wanna override every element ? if yes Press Y or N for No");



            do
            {
                Yes_No = char.Parse(Console.ReadLine());
                int[] array2 = new int[iKnowTheLengh];
                Console.WriteLine("Oho then okay enter the elements ");
                for (int i = 0; i < iKnowTheLengh; i++)
                {
                    Console.WriteLine($"For index {i}");
                    array2[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("The elements in the array before ");
                for (int i = 0; i < iKnowTheLengh; i++)
                {
                    Console.Write(array[i] + " , ");
                }

                Console.WriteLine("\n The elements after overriding it ");
                for (int i = 0; i < iKnowTheLengh; i++)
                {
                    Console.Write(array2[i] + " , ");
                }
                // Console.WriteLine("The elements in the array before: ");
                // Console.WriteLine(string.Join(", ", array));

                // Console.WriteLine("The elements after overriding: ");
                // Console.WriteLine(string.Join(", ", array2));

            } while (Yes_No == 'Y' || Yes_No == 'y');
            Console.ReadLine();



            Console.ReadKey();
        }
    }
}