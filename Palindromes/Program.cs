using System;
using Palindrome;
namespace PalindromeProgram
{
  public class Program
  {
    public static void Main()
    {
      // ask user to enter a word.
      //string inputWord = Console.ReadLine();

   string s = "robot";
        char[] charArray = s.ToCharArray();
        Console.WriteLine("charArray"+charArray);
       // PrintValues(charArray);
        for (int i = 0; i < charArray.Length; i++)
{
    Console.WriteLine(charArray[i]);
}
     // public char[] ToCharArray (int startIndex, int length);

      // Console.WriteLine("Enter the length of side 1: ");
      // int length1 = int.Parse(Console.ReadLine());

      // Console.WriteLine("Enter the length of side 2: ");
      // int length2 = int.Parse(Console.ReadLine());

      // Console.WriteLine("Enter the length of side 3: ");
      // int length3 = int.Parse(Console.ReadLine());

     // IsThisWordAPalindrome PalindromeObject = new IsThisWordAPalindrome();

      //Console.WriteLine(PalindromeObject.CheckPalindrome());
    }
  }
}

