namespace Pierres.Models
{
  public class Pastry
  {
    public int NumberOrdered { get; }

    public Pastry(int numberOrdered)
    {
      NumberOrdered = numberOrdered;
    }
  // Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
    public int totalCostOfPastries()
    {

      int fullPrice = 2;
      int orderCost = 0;

      if (NumberOrdered <= 2)
      {
        orderCost = NumberOrdered * fullPrice;
        return orderCost;
      }
      // else if (NumberOrdered == 3)
      // {
      //   return 5;
      // }
      // else if (NumberOrdered == 4)
      // {
      //   return 7;
      // }
      // else if (NumberOrdered == 5)
      // {
      //   return 9;
      // }
      // else if (NumberOrdered == 6)
      // {
      //   return 10;
      // }
      return orderCost;  
    }
  }
}