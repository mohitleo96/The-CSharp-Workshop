using System;
//Bubble sort of arrays
//class - arrays
//method - shortingArray
namespace Exercise1_09
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = [1, 2, 23, 2, 555, 2];
            Console.WriteLine("After sorting:");
            int[] sortedArray = BubbleSort(arr);
            Console.WriteLine("Sort");
            for(int i=0;i<sortedArray.Length;i++)
            {
                Console.WriteLine(sortedArray[i] + " ");
            }

        }
        public static int[] BubbleSort(int[] array)
        {
            int temp;
            //iterate over an array
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - j - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }

    }


}
