using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;
using System;

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
      int numberOrdered = 0;
      Bread newBread = new Bread(numberOrdered);

      //Act
      int result = newBread.totalCostOfBreads();

      //Assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsTotalCostOfBreadTwo_Int()
    {
      //Arrange
      int numberOrdered = 2;
      Bread newBread = new Bread(numberOrdered);

      //Act
      int result = newBread.totalCostOfBreads();

      //Assert
      Assert.AreEqual(10, result);
    }

    public void GetDescription_ReturnsTotalCostOfBreadThree_Int()
    {
      //Arrange
      int numberOrdered = 3;
      Bread newBread = new Bread(numberOrdered);

      //Act
      int result = newBread.totalCostOfBreads();

      //Assert
      Assert.AreEqual(10, result);
    }

    public void GetDescription_ReturnsTotalCostOfBreadFour_Int()
    {
      //Arrange
      int numberOrdered = 4;
      Bread newBread = new Bread(numberOrdered);

      //Act
      int result = newBread.totalCostOfBreads();

      //Assert
      Assert.AreEqual(15, result);
    }
    public void GetDescription_ReturnsTotalCostOfBread7_Int()
    {
      //Arrange
      int numberOrdered = 7;
      Bread newBread = new Bread(numberOrdered);

      //Act
      int result = newBread.totalCostOfBreads();

      //Assert
      Assert.AreEqual(25, result);
    }
  }
}