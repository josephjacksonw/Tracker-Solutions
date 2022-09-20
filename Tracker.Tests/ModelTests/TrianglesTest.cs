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
    // Test method will go here
  }
}