using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class IsThisWordAPalindromeTests
  {
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }

    [TestMethod]
    public void IsThisWordAPalindrome_CheckIfThisWordIsAPalindrome_True()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Palindrome checkPalindrome = new Palindrome();
      Assert.AreEqual(true, checkPalindrome.CheckPalindrome("radar"));
    }

  }
}

/*

bib
nun
madam
racecar
civic
deified
hannah
level
minum
mom
noon
radar
refer
rotator
sagas
solos
pop
peep
sis
redder
kayak
stats
dewed
tenet
wow

*/

