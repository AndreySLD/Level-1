using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class WeaponSlotManager : MonoBehaviour
    {
        public WeaponHolderSlot rightHandSlot;
        public WeaponHolderSlot leftHandSlot;
        PlayerInventory playerInventory;

        DamageCollider rightHandDamageCollider;
        DamageCollider leftHandDamageCollider;

        public bool isHyperArmored;

        private void Awake()
        {
            WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();
            foreach (WeaponHolderSlot weaponSlot in weaponHolderSlots)
            {
                if (weaponSlot.isRightHand)
                {
                    rightHandSlot = weaponSlot;
                } 
                else if (weaponSlot.isLeftHand)
                {
                    leftHandSlot = weaponSlot;
                }
            }
            playerInventory = GetComponentInParent<PlayerInventory>();
        }
        public void LoadBothWeaponsOnSlots()
        {
            LoadWeaponOnSlot(playerInventory.rightHandedWeapon, true);
            LoadWeaponOnSlot(playerInventory.leftHandedWeapon, false);
        }
        public void LoadWeaponOnSlot(WeaponItem weaponItem, bool isRight)
        {
            if (isRight == true)
            {
                rightHandSlot.LoadWeaponModel(weaponItem);
                LoadRightWeaponDamageCollider();    
            }
            else
            {
                leftHandSlot.LoadWeaponModel(weaponItem);
                LoadLeftWeaponDamageCollider();
            }
        }
        #region Weapon/Attack Tags
        public void ActivateHyperArmor()
        {
            isHyperArmored = true;
        }
        public void DeactivateHyperArmor()
        {
            isHyperArmored = false;
        }
        public void OpenPlungingAttack()
        {
            rightHandDamageCollider.KnockDown = true; 
            leftHandDamageCollider.KnockDown = true;
        }
        public void ClosePlungingAttack()
        {
            leftHandDamageCollider.KnockDown = false;
            rightHandDamageCollider.KnockDown = false;
        }
        #endregion
        #region Damage Colliders
        private void LoadRightWeaponDamageCollider()
        {
            rightHandDamageCollider = rightHandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
        }
        private void LoadLeftWeaponDamageCollider()
        {
            leftHandDamageCollider = leftHandSlot.currentWeaponModel.GetComponentInChildren<DamageCollider>();
        }
        public void OpenRightDamageCollider()
        {
            rightHandDamageCollider.EnableDamageCollider();
        }
        public void OpenLeftDamageCollider()
        {
            leftHandDamageCollider.EnableDamageCollider();
        }
        public void CloseRightDamageCollider()
        {
            rightHandDamageCollider.DisableDamageCollider();
        }
        public void CloseLeftDamageCollider()
        {
            leftHandDamageCollider.DisableDamageCollider();
        }
        #endregion
    }
}