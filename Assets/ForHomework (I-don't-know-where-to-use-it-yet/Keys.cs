using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class Keys : Bonus
    {
        protected override void Interaction()
        {
            PlayerInventory playerInventory = FindObjectOfType<PlayerInventory>();
            playerInventory.keyCount =+ 1;
        }
    }
}
