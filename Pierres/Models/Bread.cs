namespace Pierres.Models
{
  public class Bread
  {

    public int NumberOrdered { get; }

// Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
      
      public Bread(int numberOrdered)
      {
        NumberOrdered = numberOrdered;
      }
      
      public int totalCostOfBreads()
      {
        
        int fullPrice = 5;
        int orderCost = 0;

        if (NumberOrdered < 3)
        {
          orderCost = fullPrice * NumberOrdered;
        }
        return orderCost;
      }
    //   if (NumberOrdered == 1)
    //   {
    //     return 5;
    //   }
    //   else if (NumberOrdered == 2)
    //   {
    //     return 10;
    //   }
    //   else if (NumberOrdered == 3)
    //   {
    //     return 10;
    //   }
    //   return 0; 
    // }
  }
}