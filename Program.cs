// Adam Viera
// ISM 4300
// Class Project - Deliverable 3 - Arrays

using System;

namespace Arrays_Deliv3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Automatically populate an array with 25 elements in it
                int[] count = new int[26];
                int pop_array = 26;

                //Iterate through the array using a For loop
                for (int i = 1; i < 26; i++)
                {
                    count[i] = pop_array;
                    Console.WriteLine("The element value = " + i + " ");
                }
                Console.ReadKey(true);
            } //End of try
            catch
            {
                Console.WriteLine("Something went wrong, please go back and try again...");
                Console.ReadKey(true);
            } //End of catch


        }
    }
}
