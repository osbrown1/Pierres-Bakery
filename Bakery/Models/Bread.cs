namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }

    public decimal CalculateCost()
    {
      int discountedLoaves = Quantity / 3;
    int fullPriceLoaves = Quantity % 3;

    decimal cost = (discountedLoaves * 10m) + (fullPriceLoaves * 5m);
    return cost;
    }
  }
}

