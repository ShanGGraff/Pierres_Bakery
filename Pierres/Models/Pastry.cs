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
      if (NumberOrdered == 1)
      {
        return 2;
      }
      else if (NumberOrdered == 3)
      {
        return 5;
      }
      else if (NumberOrdered == 4)
      {
        return 7;
      }
      else if (NumberOrdered == 5)
      {
        return 9;
      }
      else if (NumberOrdered == 6)
      {
        return 10;
      }
      return 0;  
    }
  }
}