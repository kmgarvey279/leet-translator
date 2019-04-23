using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak.Models;

namespace LeetSpeak.Test
{
  [TestClass]
  public class ItemTest
  {

    // [TestMethod]
    // public void DoesLeetSpeakTranslator_ReturnArray()
    // {
    //   LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
    //   Assert.AreEqual("test", testLeetSpeakTranslator.Translate("test"));
    // }

    [TestMethod]
    public void DoesLeetSpeakTranslator_Return3ForE()
    {
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.AreEqual("33", testLeetSpeakTranslator.Translate("Ee"));
    }

    [TestMethod]
    public void DoesLeetSpeakTranslator_Return0Foro()
    {
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.AreEqual("00", testLeetSpeakTranslator.Translate("Oo"));
    }

    [TestMethod]
    public void DoesLeetSpeakTranslator_Return1ForI()
    {
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.AreEqual("1", testLeetSpeakTranslator.Translate("I"));
    }

    [TestMethod]
    public void DoesLeetSpeakTranslator_Return7Fort()
    {
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.AreEqual("77", testLeetSpeakTranslator.Translate("Tt"));
    }

    [TestMethod]
    public void DoesLeetSpeakTranslator_ReturnzFors()
    {
      LeetSpeakTranslator testLeetSpeakTranslator = new LeetSpeakTranslator();
      Assert.AreEqual("Szz", testLeetSpeakTranslator.Translate("SSs"));
    }
  }
}
