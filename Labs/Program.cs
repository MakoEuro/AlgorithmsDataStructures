// We have a list of integers where elements appear either once or twice. Find the elements that appeared twice O(n) time

int[] nums = new int[] { 1, 2, 3, 4, 7, 9, 2, 4 };

List<int> nonDupe= new List<int>();
List<int> Dupe = new List<int>();

foreach(int num in nums)
{
    if (!nonDupe.Contains(num)){
        nonDupe.Add(num);
    }
    else
    {
        Dupe.Add(num);
    }
}

foreach (int num in Dupe)
{
    Console.WriteLine(num);
}
Console.WriteLine(); 

// With this code the time complexity will be O(n).

// We have two sorted int arrays which could be with different sizes.
// We need to merge them in a third array while keeping this result array sorted.
// Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries

int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[] { 2, 5, 7, 9, 13 };

foreach(int num in arr1)
{
    Console.Write(num + " ");
}
Console.WriteLine();

foreach(int num in arr2)
{
    Console.Write(num + " ");
}
Console.WriteLine();

int[] arr3 = arr1.Concat(arr2).OrderBy(w => w).ToArray();
// Creates array 3 which copies array 2 into array 1 while also sorting into ascending

foreach(int num in arr3)
{
    Console.Write(num + " ");
}
Console.WriteLine();

// Time complexity is O(n)

// Given an integer, reverse the digits of that integer, input is 3415, output is 5143.

Console.WriteLine();
Console.WriteLine("Input a number you would like to reverse:");
string inputRevr = Console.ReadLine();
char[] reverseIn = inputRevr.ToCharArray();
Array.Reverse(reverseIn);

foreach(char num in reverseIn)
{
    Console.Write(num);
}

// Time complexity should be O(n) due to resulting in loops dependant on characters inputted