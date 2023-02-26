using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CalculatesBreadCost_15()
    {
      var bread = new Bread { Quantity = 4 };
      decimal cost = bread.CalculateCost();
      Assert.AreEqual(15m, cost);
    }
  }
}