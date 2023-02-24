namespace PierreBakery.Models
{
  public class Bread
  {
    public int Quantity {get; set;}

    public decimal CalculateCost()
    {
      int freeLoaves = Quantity / 3;
      int paidLoaves = Quantity - freeLoaves;

      return 
    }
  }
}



