using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumsToWordsTests
  {
    [TestMethod]
    public void OnesConverter_1EqualsOne_True()
    {
      Assert.AreEqual("one", NumsToWords.OnesConverter('1'));
    }

    [TestMethod]
    public void TeensConverter_13EqualsThirteen_True()
    {
      Assert.AreEqual("Thirteen", NumsToWords.TeensConverter('13'));
    }
  }
}