using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        [HideInInspector]
        public bool isHyperArmored;
        [HideInInspector]
        public bool allowRagdoll;

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
            //try
            //{
            //    rightHandDamageCollider.KnockDown = true;
            //    leftHandDamageCollider.KnockDown = true;
            //    if (leftHandDamageCollider || rightHandDamageCollider == null) throw new Exception();
            //}
            //catch
            //{
            //    Debug.Log(message: "����������� ������");
            //}
            if (rightHandDamageCollider != null)
            {
                rightHandDamageCollider.KnockDown = true;
            }
            else
            {
                throw new Exception(message: "����������� ������ � ������ ����");
            }
            if (leftHandDamageCollider != null)
            {
                leftHandDamageCollider.KnockDown = true;
            }
            else
            {
                throw new Exception(message: "����������� ������ � ����� ����");
            }
        }
        public void ClosePlungingAttack()
        {
            if (rightHandDamageCollider != null)
            {
                rightHandDamageCollider.KnockDown = false;
            }
            else
            {
                throw new Exception(message: "����������� ������ � ������ ����");
            }
            if (leftHandDamageCollider != null)
            {
                leftHandDamageCollider.KnockDown = false;
            }
            else
            {
                throw new Exception(message: "����������� ������ � ����� ����");
            }
        }
        public void EnableRagdoll()
        {
            allowRagdoll = true;
        }
        public void DisableRagdoll()
        {
            allowRagdoll = false;
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
            if (rightHandDamageCollider != null)
            {
                rightHandDamageCollider.EnableDamageCollider();
            }
        }
        public void OpenLeftDamageCollider()
        {
            if (leftHandDamageCollider != null)
            {
                leftHandDamageCollider.EnableDamageCollider();
            }
        }
        public void CloseRightDamageCollider()
        {
            if (rightHandDamageCollider != null)
            {
                rightHandDamageCollider.DisableDamageCollider();
            }
        }
        public void CloseLeftDamageCollider()
        {
            if (leftHandDamageCollider != null)
            {
                leftHandDamageCollider.DisableDamageCollider();
            }
        }
        #endregion
    }
}