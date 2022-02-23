using System;
using Palindrome;
namespace PalindromeProgram
{
  public class Program
  {
    public static void Main(string[] args)
    {      
      string input;
      Console.WriteLine("Enter a word to check if it's a palindrome.");
      input = Console.ReadLine();
      
      Palindrome palindrome = new Palindrome();

      Console.WriteLine(palindrome.CheckPalindrome(input));

      
    }
  }
}

