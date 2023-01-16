// Enter num for words
Console.WriteLine("Program for counting characters.");
Console.WriteLine("Enter a number (for words)");
int count = Int32.Parse(Console.ReadLine());

// Enter words
Console.WriteLine("Enter " + count + " words");
string[] words = new string[count-1];
for (int i = 0; i <= count; i++)
{
    words[i] = Console.ReadLine(); 
}

Console.WriteLine("Now type in a letter for the program to search and count: ");


