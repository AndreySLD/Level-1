using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class EnemyInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotManager;

        public WeaponItem rightHandedWeapon;
        public WeaponItem leftHandedWeapon;

        private void Awake()
        {
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }
        private void Start()
        {
            weaponSlotManager.LoadWeaponOnSlot(rightHandedWeapon, true);
            weaponSlotManager.LoadWeaponOnSlot(leftHandedWeapon, false);
        }
    }
}
