using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
{
[TestMethod]
public void PastryConstructor_CalculatesPastryCost_12()
{
    var pastry = new Pastry { Quantity = 7 };
        decimal cost = pastry.CalculateCost();
        Assert.AreEqual(12m, cost);
}

[TestMethod]
public void PastryConstructor_CalculatesPastryCost_6()
{
    var pastry = new Pastry { Quantity = 3 };
        decimal cost = pastry.CalculateCost();
        Assert.AreEqual(6m, cost);
}
}
}