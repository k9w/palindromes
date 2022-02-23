using System;
using Palindrome;
namespace Palindrome
{
  public class Palindrome
  {
    public void CheckPalindrome(string string1)
    {
      string reversedString;
      char[] charArray = string1.ToCharArray();
      Array.Reverse(charArray);
      reversedString = new string(charArray);
      bool isPalindrome = string1.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
      if (isPalindrome == true)
      {
        Console.WriteLine(string1 + " is a Palindrome.");
      }
      else
      {
        Console.WriteLine(string1 + " is not a Palindrome.");
      }
    }
  }
}
