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
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsBreadOrdered_Int()
    {
      //Arrange
      int numberOrdered = 3;
      Bread newBread = new Bread(numberOrdered);

      //Act
      int result = newBread.NumberOrdered;

      //Assert
      Assert.AreEqual(numberOrdered, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsPastryOrdered_Int()
    {
      //Arrange
      int numberOrdered = 3;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.NumberOrdered;

      //Assert
      Assert.AreEqual(numberOrdered, result);
    }

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