namespace Pierres.Models
{
  public class Bread
  {

    public int NumberOrdered { get; }
      
    public Bread(int numberOrdered)
    {
      NumberOrdered = numberOrdered;
    }
      
    public int totalCostOfBreads()
    {
        
      int fullPrice = 5;
      int orderCost = 0;
      int numOfDiscount = NumberOrdered / 3;

      if (NumberOrdered >= 3)
      {
        orderCost = (fullPrice * NumberOrdered) - (numOfDiscount  * fullPrice);
      }
      else
      {
        orderCost = NumberOrdered * fullPrice;
      }
      return orderCost;
    }
  }
}