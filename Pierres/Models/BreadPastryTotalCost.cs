namespace Pierres.Models
{
  public class BreadPastryTotalCost
  {

    public int TotalCostOfBread { get; }
    public int TotalCostOfPastries { get; }

    public BreadPastryTotalCost(int totalCostOfBread, int totalCostOfPastries)
    {
      TotalCostOfBread = totalCostOfBread;
      TotalCostOfPastries = totalCostOfPastries;
    }

    public int TotalCost()
    {
      return TotalCostOfBread + TotalCostOfPastries;
    }
  }
}
