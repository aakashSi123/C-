using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array_Neg_Element_finder
{
    public class NegNumInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements for The array \"only 5");
            int input_num = 5, i = 0;

            int[] neg_in_array = new int[input_num]; // array creation
            for (i = 0; i < input_num; i++)     // loop for taking user input 
            {
                neg_in_array[i] = int.Parse(Console.ReadLine());

            }

            // for (i = 0; i < neg_in_array.Length; i++)
            // {
            //     if (neg_in_array[i] < 0)
            //     {
            //         Console.WriteLine("the negative element are " + neg_in_array.ElementAt(i));
            //     }
            //     else if (neg_in_array[i] > 0)
            //     {
            //         Console.WriteLine("the positive element are " + neg_in_array.ElementAt(i));
            //     }
            //     else if(neg_in_array[i] == 0)
            //     {
            //         Console.WriteLine("The Number neither negative nor positive " + neg_in_array.ElementAt(i));
            //     }
            // }

            System.Console.Write("The negative number in the array are :-  ");

            for (i = 0; i < neg_in_array.Length; i++)
            {
                if (neg_in_array[i] < 0)
                {
                    System.Console.Write(" " + neg_in_array.ElementAt(i));
                }
            }

            System.Console.Write("\n The positive number in the array are :-  ");

            for (i = 0; i < neg_in_array.Length; i++)
            {
                if (neg_in_array[i] > 0)
                {
                    System.Console.Write(" " + neg_in_array.ElementAt(i));
                }
            }

            System.Console.Write("\n The negative number neighter positive nor negative is ");
            for (i = 0; i < neg_in_array.Length; i++)
            {
                if (neg_in_array[i] == 0)
                {
                    System.Console.Write(" " + neg_in_array.ElementAt(i));
                }
            }
        }
    }

}