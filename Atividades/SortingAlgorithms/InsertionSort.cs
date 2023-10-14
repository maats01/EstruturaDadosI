using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwapTool;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public static void sort<T>(T[] array) where T : IComparable
        {
            for(int i = 1; i < array.Length; i++)
            {
                int j = i;

                while(j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap.swap<T>(array, j, j - 1);
                    j--;
                }
            }
        }
    }
}