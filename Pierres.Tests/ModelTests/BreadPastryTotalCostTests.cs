using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
{
  [TestClass]
  public class BreadPastryTotalCostTests
  {

    [TestMethod]
    public void BreadPastryTotalCostConstructor_CreatesInstanceOfBreadPastryTotalCost_BreadPastryTotalCost()
    {
      BreadPastryTotalCost newBreadPastryTotalCost = new BreadPastryTotalCost(3, 5);
      Assert.AreEqual(typeof(BreadPastryTotalCost), newBreadPastryTotalCost.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsBreadPastryTotalCost_Int()
    {
      //Arrange
      int numberOrderedOne = 3;
      int numberOrderedTwo = 5;
      int totalReturned = numberOrderedOne + numberOrderedTwo;

      BreadPastryTotalCost newBreadPastryTotalCost = new BreadPastryTotalCost(numberOrderedOne, numberOrderedTwo);

      //Act
      int result = newBreadPastryTotalCost.TotalCost();

      //Assert
      Assert.AreEqual(totalReturned, result);
    }
  }
}