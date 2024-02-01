using System;
namespace SelectionSort
{
    class MAIN
    {
        static void Main()
        {
            int[] arr = { 35,65,13,18,19,50,69};

            printArray(arr);

            SelectionSort(arr);

            Console.WriteLine(" Sorted array");
            printArray(arr);
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++) 
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        static void printArray(int[] arr)
        { 
            foreach (var elemente in arr)
            {
                Console.WriteLine(elemente + " ");
            }
            Console.WriteLine();
        }
    }
}