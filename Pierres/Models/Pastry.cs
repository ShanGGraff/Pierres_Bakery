namespace Pierres.Models
{
  public class Pastry
  {
    public int NumberOrdered { get; }

    public Pastry(int numberOrdered)
    {
      NumberOrdered = numberOrdered;
    }
    public int totalCostOfPastries()
    {

      int fullPrice = 2;
      int threeOrderDiscount = 5;
      int orderCost = 0;
      int num = NumberOrdered / 3;
      int numRemainder = NumberOrdered % 3;

      if (NumberOrdered <= 2)
      {
        orderCost = NumberOrdered * fullPrice;
        return orderCost;
      } 
      else 
      {
        orderCost = ((numRemainder * fullPrice) + (num * threeOrderDiscount));
      }
      return orderCost;  
    }
  }
}