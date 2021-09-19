using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
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
    public void GetDescription_ReturnsTotalCostOfBreadOne_Int()
    {
      //Arrange
      int numberOrdered = 1;
      Bread newBread = new Bread(numberOrdered);

      //Act
      int result = newBread.totalCostOfBreads();

      //Assert
      Assert.AreEqual(5, result);
    }

    // [TestMethod]
    // public void GetDescription_ReturnsTotalCostOfBreadTwo_Int()
    // {
    //   //Arrange
    //   int numberOrdered = 2;
    //   Bread newBread = new Bread(numberOrdered);

    //   //Act
    //   int result = newBread.totalCostOfBreads();

    //   //Assert
    //   Assert.AreEqual(10, result);
    // }
  }
}