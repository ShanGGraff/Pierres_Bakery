using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
{
  [TestClass]
  public class PierresTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    // [TestMethod]
    // public void DoesBreadNumber_ConatainCorrectInt_True()
    // {
    //   Bread testBread = new Bread();
    //   Assert.AreEqual(2, testBread.NumberOfBreads(2));
    // }

    // [TestMethod]
    // public void DoesPastryNumber_ConatainCorrectInt_True()
    // {
    //   Pastry testPastry = new Pastry();
    //   Assert.AreEqual(2, testPastry.NumberOfPastries(2));
    // }
    
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   // Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}