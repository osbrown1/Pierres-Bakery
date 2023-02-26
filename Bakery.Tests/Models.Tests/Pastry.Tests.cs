using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
[TestMethod]
    public void PastryConstructor_CalculatesPastryCost_8()
    {
      var pastry = new Pastry { Quantity = 5 };
      decimal cost = pastry.CalculateCost();
      Assert.AreEqual(8m, cost);
    }
  }
}