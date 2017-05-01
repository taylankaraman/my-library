using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] tokens_n = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(tokens_n[0]);
            //int k = Convert.ToInt32(tokens_n[1]);
            //string[] a_temp = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int[] input_array = { 1, 2, 3, 4, 5 };
            int[] result_array = new int[input_array.Length];
            int n = 5;
            int k = 6;

            // Mod the number of rotations
            k = k % n;

            if(k == 0)
            {                
                input_array.CopyTo(result_array, 0);
            }
            else
            {
                result_array = leftShift(input_array, k);
            }
            
            Console.Write("Input Array: ");
            foreach (int i in input_array)
            {
                Console.Write("{0} ", i);
            }

            Console.Write("\n");
            Console.Write("Result Array: ");
            foreach (int i in result_array)
            {
                Console.Write("{0} ", i);
            }


        }

        // Left shift k times
        static int[] leftShift(int[] input_array, int k)
        {
            int[] result_array = new int[input_array.Length];

            for (int i = 0; i < input_array.Length; i++)
            {
                if (i < k)
                {
                    result_array[i - k + input_array.Length] = input_array[i];
                }
                else
                {
                    result_array[i - k] = input_array[i];
                }
            }

            return result_array;
        }
    }
}
