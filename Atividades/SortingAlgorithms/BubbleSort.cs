using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwapTool;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public static void sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap.swap<T>(array, j, j + 1);
                    }
                }
                
                if(!isAnyChange)
                    break;   
            }
        }
    }
}