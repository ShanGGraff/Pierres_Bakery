using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;

namespace Pierres.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
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
    public void GetDescription_ReturnsTotalCostOfOnePastry_Int()
    {
      //Arrange
      int numberOrdered = 1;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.totalCostOfPastries();

      //Assert
      Assert.AreEqual(2, result);
    }
  }
}