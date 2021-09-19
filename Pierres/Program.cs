using System;
using Pierres.Models;

namespace Pierres_Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("      Hello, Welcome to Pierre's Bakery!");
      Console.WriteLine("");
      Console.WriteLine(@"      Here are our bread prices: 
      A single loaf costs $5, two loaves cost $10, and three 
      loaves cost $10.");
      Console.WriteLine("");
      Console.WriteLine(@"      Here are our pastry prices: 
      Buy 1 for $2 or 3 for $5. Four pastries cost $7, 
      five pastries cost $9, and six pastries cost $10");
      Console.WriteLine("");
      Console.WriteLine("      How many loaves of bread would you like? Please choose 0-3.");
      int numberOfBread = Int16.Parse(Console.ReadLine());
      Bread newBread = new Bread(numberOfBread);
      Console.WriteLine("");
      Console.WriteLine("      How many pastries would you like? Please choose 0, 1, 3, 4, 5 or 6.");
      int numberOfPastries = Int16.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(numberOfPastries);
      BreadPastryTotalCost newBreadPastryTotalCost = new BreadPastryTotalCost(newBread.totalCostOfBreads(), newPastry.totalCostOfPastries());
      Console.WriteLine("");
      Console.WriteLine("      The total cost of your order is: $" + newBreadPastryTotalCost.TotalCost());

    }
  }
}