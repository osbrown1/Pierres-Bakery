namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public decimal CalculateCost()
    {
      int freePastries = Quantity / 4;
        int paidPastries = Quantity - freePastries;

        return (freePastries * 2m) + (paidPastries * 2m);
    }
  }
}