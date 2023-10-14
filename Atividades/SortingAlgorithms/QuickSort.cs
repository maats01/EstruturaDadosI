using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwapTool;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public static void sort(int[] array, int start, int end)
        {
            if(end <= start) return;
            
            int pivot = partition(array, start, end);
            sort(array, start, pivot - 1);
            sort(array, pivot + 1, end);

        }
        private static int partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;

            for(int j = start; j <= end - 1; j++)
            {
                if(array[j] < pivot)
                {
                    i++;
                    Swap.swap(array, i, j);
                }
            }
            i++;
            Swap.swap(array, i, end);

            return i;
        }
    }
}