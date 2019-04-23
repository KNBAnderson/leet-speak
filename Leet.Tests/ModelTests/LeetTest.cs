using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;

namespace Leet.Tests
{
  [TestClass]
  public class LeetTest
  {
    [TestMethod]
    public void MakeLeetSpeak_LetterIsE_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual('3', testLeetSpeak.MakeLeetSpeak('e'));
    }
  }
}
