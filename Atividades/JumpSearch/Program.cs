using System;

int[] arr = new int[] {
    1, 2, 3 , 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
};

Console.WriteLine("Número a ser procurado: ");
int target = Convert.ToInt32(Console.ReadLine());

bool Search(int[] arr, int target)
{
    int n = arr.Length;
    int m = Convert.ToInt32(Math.Sqrt(n));
    int min, max;

    for (int i = 0; i < n; i += m)
    {
        min = i;
        max = i+m;

        if (max > n-1)
            max = n-1;

        if (target >= arr[min] && target <= arr[max])
        {
            for (int j = min; j <= max; j++)
            {
                if (arr[j] == target)
                    return true;
            }
        }
    }
    
    return false;
}

Console.WriteLine(Search(arr, target));