using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS 
{
    public class ConsumableItem : Item
    {
        
        [Header("Item Count")]
        public int maxItemAmount;
        public int currentItemAmount;

        [Header("Item Model")]
        public GameObject itemModel;

        [Header("Animations")]
        public string consumableAnimation;
        public bool IsInteracting;

        
        public virtual void AttemptToUseConsumableItem(AnimatorManager animatorManager, WeaponSlotManager weaponSlotManager, PlayerEffectsManager playerEffectsManager)
        {
            if (currentItemAmount > 0 && !IsInteracting)
            {
                animatorManager.PlayTargetAnimation(consumableAnimation, true);
            }
            else if (currentItemAmount <= 0 && !IsInteracting)
            {
                currentItemAmount = 0;
                animatorManager.PlayTargetAnimation("OutOfThing", true);
            }
        }
    }
}
