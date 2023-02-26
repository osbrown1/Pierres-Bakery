namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public decimal CalculateCost()
{
    int discountedLoaves = Quantity / 4;
    int fullPriceLoaves = Quantity % 4;

    decimal cost = (discountedLoaves * 6m) + (fullPriceLoaves * 2m);

    return cost;
}
  }
}