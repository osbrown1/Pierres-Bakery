using System;

namespace Bakery.Models
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Owen's Bakery!");

      Console.WriteLine("How many loaves of bread would you like?");
      int breadQuantity = int.Parse(Console.ReadLine());
      Bread bread = new Bread { Quantity = breadQuantity };

      Console.WriteLine("How many pastries would you like?");
      int pastryQuantity = int.Parse(Console.ReadLine());
      Pastry pastry = new Pastry { Quantity = pastryQuantity };

      decimal totalCost = bread.CalculateCost() + pastry.CalculateCost();

      Console.WriteLine($"Your order total is: ${totalCost}. Thank you for shopping at Owen's Bakery. Have a nice day.");
    }
  }
}
