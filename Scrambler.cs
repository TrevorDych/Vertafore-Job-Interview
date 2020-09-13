using System;


namespace Scrambler // Method that scambles the values of a sorted integer array
{
    class Program
    {

        public static void scrambler(int[] arr)
        {
            try
            {
                int arrLength = arr.Length;
                Random rand = new Random();

                for (int i = 0; i < arrLength; i++)
                {
                    swap(arr, i, i + rand.Next(arrLength - i)); //swaps with a random index that is further in the array than i
                }
            }
            catch { Console.WriteLine("Scrambler has encountered an error."); }
        }
        public static void swap(int[] arr, int one, int two) //int two will be a random index from further into the array
        {
            int temp = arr[one];
            arr[one] = arr[two];
            arr[two] = temp;
        }


        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 564 }; //given sorted array
            int[] arr2 = { 100, 95, 87, 64, 55, 49, 42, 37, 34, 22, 17, 8, 2 };

            scrambler(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }


    }

}
