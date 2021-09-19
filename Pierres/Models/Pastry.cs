namespace Pierres
{
  public class Pastry
  {
    public int NumberOrdered { get; }

      public Pastry(int numberOrdered)
      {
        NumberOrdered = numberOrdered;
      }
      // Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
      //  public int totalCostOfPastries()
      // {
      //   int totalCost = 0;
      //   if (numberedOrdered == 1)
      //     return (2);
      // }
  }
}