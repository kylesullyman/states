using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBaseState
{
   protected FarmingStateManager farmingStateManager;

   public PlantBaseState(FarmingStateManager farmingStateManager)
   {
      this.farmingStateManager = farmingStateManager;
   }
}
