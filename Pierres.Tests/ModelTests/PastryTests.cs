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

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfTwoPastry_Int()
    {
      //Arrange
      int numberOrdered = 2;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.totalCostOfPastries();

      //Assert
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfThreePastry_Int()
    {
      //Arrange
      int numberOrdered = 3;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.totalCostOfPastries();

      //Assert
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfFourPastry_Int()
    {
      //Arrange
      int numberOrdered = 4;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.totalCostOfPastries();

      //Assert
      Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfFivePastry_Int()
    {
      //Arrange
      int numberOrdered = 5;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.totalCostOfPastries();

      //Assert
      Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfSixPastry_Int()
    {
      //Arrange
      int numberOrdered = 6;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.totalCostOfPastries();

      //Assert
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfTenPastry_Int()
    {
      //Arrange
      int numberOrdered = 10;
      Pastry newPastry = new Pastry(numberOrdered);

      //Act
      int result = newPastry.totalCostOfPastries();

      //Assert
      Assert.AreEqual(17, result);
    }
  }
}