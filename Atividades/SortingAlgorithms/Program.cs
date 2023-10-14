using SortingAlgorithms;

Console.WriteLine("Selection Sort");
int[] nums = new int[]{
    12, 5, 4, 3, 7, -11, -55
};

SelectionSort.sort<int>(nums);

Console.WriteLine(string.Join(" | ", nums));

Console.WriteLine("");

Console.WriteLine("Insertion Sort");

int[] nums2 = new int[]{
    9, 8, 7, 6, 5, 4, 3, 2, 1
};

InsertionSort.sort<int>(nums2);

Console.WriteLine(string.Join(" | ", nums2));

Console.WriteLine("");

Console.WriteLine("Bubble Sort");

int[] nums3 = new int[]{
    123, 3, 23, 4576, 456, 123, 5
};

BubbleSort.sort<int>(nums3);

Console.WriteLine(string.Join(" | ", nums3));

Console.WriteLine("");

Console.WriteLine("Quick Sort");

int[] nums4 = new int[]{
    32, 77, 44, 29, 360, 120, 1024
};

QuickSort.sort(nums4, 0, nums4.Length - 1);

Console.WriteLine(string.Join(" | ", nums4));
