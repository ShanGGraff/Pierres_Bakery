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
    public void BreadPastryTotalCostConstructor_CreatesInstanceOfBreadPastryTotalCost_BreadPastryTotalCost()
    {
      BreadPastryTotalCost newBreadPastryTotalCost = new BreadPastryTotalCost(3, 5);
      Assert.AreEqual(typeof(BreadPastryTotalCost), newBreadPastryTotalCost.GetType());
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
    public void GetDescription_ReturnsPastriesOrdered_Int()
    {
      //Arrange
      int numberOrdered = 3;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.NumberOrdered;

      //Assert
      Assert.AreEqual(numberOrdered, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfBread_Int()
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
    // public void GetDescription_ReturnsBreadPastryTotalCost_Int()
    // {
    //   //Arrange
    //   int numberOrderedOne = 3;
    //   int numberOrderedTwo = 5;
    //   int totalReturned = numberOrderedOne + numberOrderedOne;

    //   BreadPastryTotalCost newBreadPastryTotalCost = new BreadPastryTotalCost(numberOrderedOne, numberOrderedTwo);

    //   //Act
    //   int result = newBreadPastryTotalCost.TotalCost;

    //   //Assert
    //   Assert.AreEqual(totalReturned, result);
    // }
  }
}