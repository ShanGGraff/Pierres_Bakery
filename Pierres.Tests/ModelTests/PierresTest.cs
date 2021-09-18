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
    // public GetPrice_ReturnPrice_Int()
    // {
    //   int numberOrdered = 1;
    //   Bread newBread = new Bread(numberOrdered);
    // }

    [TestMethod]
    public void BreadPastryTotalCostConstructor_CreatesInstanceOfBreadPastryTotalCost_BreadPastryTotalCost()
    {
      BreadPastryTotalCost newBreadPastryTotalCost = new BreadPastryTotalCost();
      Assert.AreEqual(typeof(BreadPastryTotalCost), newBreadPastryTotalCost.GetType());
    }
  }
}