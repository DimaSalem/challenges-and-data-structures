using System.ComponentModel;
using System.Diagnostics;

namespace cc1
{
    internal class Program
    {
      
        //Find Duplicates
        static int[] copyArray(int[] arrTo, int[] arrFrom)
        {
            for (int i = 0; i < arrTo.Length; i++)
            {
                arrTo[i] = arrFrom[i];
            }
            return arrTo;
        }
        static int[] FindDuplicates(int[] arr)
        {
            int[] tempDuplicates= new int[arr.Length];
            int deplicatesCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        tempDuplicates[deplicatesCount++] = arr[j];
                }
            }
            int[] arrDuplicates= new int[deplicatesCount];
            copyArray(arrDuplicates, tempDuplicates);
            return arrDuplicates;
        }
        static void Main(string[] args)
        {


            int[] arr = FindDuplicates(new int[] { 100, 1, 2,2,5, 5, 3, 4, 4, 100});

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
