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

        public WeaponItem unarmedWeapon;

        public WeaponItem[] weaponsInRightHand = new WeaponItem[1];
        public WeaponItem[] weaponsInLeftHand = new WeaponItem[1];

        public int currentRightWeaponIndex = -1;
        public int currentLeftWeaponIndex = -1;

        public int keyCount;

        private void Awake()
        {
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }
        private void Start()
        {
            rightHandedWeapon = unarmedWeapon;
            leftHandedWeapon = unarmedWeapon;

            currentCunsumable.currentItemAmount = currentCunsumable.maxItemAmount;
        }
        public void ChangeWeaponInRightHand()
        {
            currentRightWeaponIndex = currentRightWeaponIndex + 1;

            if (currentRightWeaponIndex == 0 && weaponsInRightHand[0] != null)
            {
                rightHandedWeapon = weaponsInRightHand[currentRightWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInRightHand[currentRightWeaponIndex], true);
            }
            else if (currentRightWeaponIndex == 0 && weaponsInRightHand[0] == null)
            {
                currentRightWeaponIndex = currentRightWeaponIndex + 1;
            }
            else if (currentRightWeaponIndex == 1 && weaponsInRightHand[1] != null)
            {
                rightHandedWeapon = weaponsInRightHand[currentRightWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInRightHand[currentRightWeaponIndex], true);
            }
            else
            {
                currentRightWeaponIndex = currentRightWeaponIndex + 1;
            }
            
            if (currentRightWeaponIndex > weaponsInRightHand.Length - 1)
            {
                currentRightWeaponIndex = -1;
                rightHandedWeapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, true);
            }
        }
        public void ChangeWeaponInLeftHand()
        {
            currentLeftWeaponIndex = currentLeftWeaponIndex + 1;

            if (currentLeftWeaponIndex == 0 && weaponsInLeftHand[0] != null)
            {
                leftHandedWeapon = weaponsInLeftHand[currentLeftWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInLeftHand[currentLeftWeaponIndex], false);
            }
            else if (currentLeftWeaponIndex == 0 && weaponsInLeftHand[0] == null)
            {
                currentLeftWeaponIndex = currentLeftWeaponIndex + 1;
            }
            else if (currentLeftWeaponIndex == 1 && weaponsInLeftHand[1] != null)
            {
                leftHandedWeapon = weaponsInLeftHand[currentLeftWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInLeftHand[currentLeftWeaponIndex], false);
            }
            else
            {
                currentLeftWeaponIndex = currentLeftWeaponIndex + 1;
            }

            if (currentLeftWeaponIndex > weaponsInLeftHand.Length - 1)
            {
                currentLeftWeaponIndex = -1;
                leftHandedWeapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
            }
        }
    }
}
