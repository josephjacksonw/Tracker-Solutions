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
  }
}