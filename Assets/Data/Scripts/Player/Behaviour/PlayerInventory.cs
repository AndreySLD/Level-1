using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class PlayerInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotManager;
        
        public WeaponItem rightHandedWeapon;
        public WeaponItem leftHandedWeapon;
        public ConsumableItem currentCunsumable;

        private void Awake()
        {
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }
        private void Start()
        {
            weaponSlotManager.LoadWeaponOnSlot(rightHandedWeapon, true);
            weaponSlotManager.LoadWeaponOnSlot(leftHandedWeapon, false);
            currentCunsumable.currentItemAmount = currentCunsumable.maxItemAmount;
        }
    }
}
