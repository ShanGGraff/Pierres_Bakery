namespace Pierres.Models
{
  public class Bread
  {

    public int NumberOrdered { get; }

    // public static void ClearBread()
    // {
    //   Bread.NumberOrdered.Clear();
    // } 

      public Bread(int numberOrdered)
      {
        NumberOrdered = numberOrdered;
      }
    // Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
      
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