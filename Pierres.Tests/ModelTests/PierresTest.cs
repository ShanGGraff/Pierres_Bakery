using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
{
  [TestClass]
  public class PierresTests
  {
    [TestMethod]
    public void DoesBreadNumber_ConatainAnInt_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(true, testBread.NumberOfBreads(2));
      //testing code will go here
    }
  }
}