using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;

namespace Leet.Tests
{
  [TestClass]
  public class LeetTest
  {
    [TestMethod]
    public void MakeLeetSpeak_LetterIsNotLeet_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual('d', testLeetSpeak.MakeLeetSpeak('d'));
    }
    [TestMethod]
    public void MakeLeetSpeak_LetterIsE_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual('3', testLeetSpeak.MakeLeetSpeak('e'));
    }
    [TestMethod]
    public void MakeLeetSpeak_LetterIsO_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual('0', testLeetSpeak.MakeLeetSpeak('o'));
    }
    [TestMethod]
    public void MakeLeetSpeak_LetterIsI_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual('1', testLeetSpeak.MakeLeetSpeak('I'));
    }
    [TestMethod]
    public void MakeLeetSpeak_LetterIsT_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual('7', testLeetSpeak.MakeLeetSpeak('T'));
    }
    [TestMethod]
    public void AssessWord_WordIsLeet_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("y0u", testLeetSpeak.AssessWord("you"));
    }
    [TestMethod]
    public void AssessWord_SWordIsLeet_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("sn3k", testLeetSpeak.AssessWord("snek"));
    }
  }
}
