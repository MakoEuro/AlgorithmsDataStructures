// A program that produces an array of all of the characters that appear more than once in a string.

using System.Collections.Generic;

string input = "Programmatic Python".ToLower();
List<char> dupe = new List<char>();
foreach (var item in input)
{
    if (input.IndexOf(item) != input.LastIndexOf(item) && !dupe.Contains(item))
    {
        dupe.Add(item);
    }
}

Console.WriteLine(string.Join(", ", dupe));
Console.WriteLine();

// A program returns an array of strings that are unique words found in the argument.

Console.WriteLine("This sentence will remove all duplicate words:");
string sentence = "to be or not to be";
Console.WriteLine(sentence);
string newSentence = string.Join(" ", sentence.Split(' ').Distinct());

Console.WriteLine("New sentence:");
Console.WriteLine(newSentence);
Console.WriteLine();

// A program that reverses a provided string 

Console.WriteLine("This sentence will be reversed:");
string reverseString = "Have you met my cat named tacocat?";
Console.WriteLine(reverseString);
char[] reverseArray = reverseString.ToCharArray();
Array.Reverse(reverseArray);
Console.WriteLine("The sentence reversed:");
Console.WriteLine(reverseArray);
Console.WriteLine();

// A program that finds the longest unbroken word in a string and prints it

string sentence2 = "Within this sentence holds a number of words to find the declared longest.";
Console.WriteLine(sentence2);
string[] newSentence2 = sentence2.Split(" ".ToString());
int longestCalc = newSentence2.Max(w => w.Length);
string longestString = newSentence2.OrderByDescending(w => w.Length).First();
Console.WriteLine($"The longest word in the sentence is {longestCalc} letters long and is: {longestString}");