using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwapTool;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public static void sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                T minValue = array[i];
                int minIndex = i;
                
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[j].CompareTo(minValue) < 0)
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }

                Swap.swap<T>(array, i, minIndex);
            }
        }
    }
}