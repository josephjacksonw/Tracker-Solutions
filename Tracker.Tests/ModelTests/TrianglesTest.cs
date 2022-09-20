using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_AllSidesCanReach_True()
    {
      Checker variableName = new Checker();
      Assert.AreEqual(true, variableName.IsTriangle(3, 4, 5));
    }
    [TestMethod]
    public void IsTriangle_AllSidesCanReach_False()
    {
      Checker variableName = new Checker();
      Assert.AreEqual(false, variableName.IsTriangle(10, 4, 5));
    }
    // Test method will go here
    [TestMethod]
    public void checkType_AllSideDifferentLengths_Equilateral()
    {
      Checker variableName = new Checker();
      Assert.AreEqual("This is an equilateral triangle!", variableName.checkType(3,3,3));
    }
    [TestMethod]
    public void checkType_AllSideDifferentLengths_Isosceles()
    {
      Checker variableName = new Checker();
      Assert.AreEqual("This is an isosceles triangle!", variableName.checkType(3,3,4));
    }
    [TestMethod]
    public void checkType_AllSideDifferentLengths_Scalene()
    {
      Checker variableName = new Checker();
      Assert.AreEqual("This is a scalene triangle!", variableName.checkType(3,4,5));
    }
  }


}