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
      if (NumberOrdered == 1)
      {
        return 5;
      }
      else if (NumberOrdered == 2)
      {
        return 10;
      }
      else if (NumberOrdered == 3)
      {
        return 10;
      }
      return 0; 
    }
  }
}