using System;

namespace Array
{
    class Compare
    {
        static void Main(string[] args)
        {
            
            int[] Arr1 = new int[5];

          
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < Arr1.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                Arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numbers within the Array:");
            foreach (int num in Arr1)
            {
                Console.WriteLine(num);
            }

            int bigger = Arr1[0];
            for (int i = 1; i < Arr1.Length; i++)
            {
                if (Arr1[i] > bigger)
                {
                    bigger = Arr1[i];
                }
            }

            Console.WriteLine("The largest element in the array is: " + bigger);

            Console.ReadKey();
        }
    }
}