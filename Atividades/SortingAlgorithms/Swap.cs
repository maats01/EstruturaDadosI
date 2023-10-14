using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace SwapTool
{
    public class Swap
    {
        public static void swap<T>(T[] array, int a, int b)
        {
            T aux = array[a];
            array[a] = array[b];
            array[b] = aux;
        }
    }
}