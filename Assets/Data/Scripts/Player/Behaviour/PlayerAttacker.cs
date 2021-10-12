using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class PlayerAttacker : MonoBehaviour
    {
        AnimatorHandler animatorHandler;
        InputHandler inputHandler;

        public string lastAttack;

        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            inputHandler = GetComponent<InputHandler>();
        }
        public void HandleWeaponCombo(WeaponItem weapon)
        {
            if (inputHandler.comboFlag)
            {
                animatorHandler.anim.SetBool("canCombo", false);
                if (lastAttack == weapon.OH_Light_Attack_01 && inputHandler.la_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_02, true);
                    lastAttack = weapon.OH_Light_Attack_02;
                }
                if (lastAttack == weapon.OH_Light_Attack_01 && inputHandler.ha_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_01, true);
                    lastAttack = weapon.OH_Heavy_Attack_01;
                }
                if (lastAttack == weapon.OH_Light_Attack_02 && inputHandler.la_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_01, true);
                    lastAttack = weapon.OH_Light_Attack_01;
                }
                if (lastAttack == weapon.OH_Light_Attack_02 && inputHandler.ha_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_01, true);
                    lastAttack = weapon.OH_Heavy_Attack_01;
                }                                
                if (lastAttack == weapon.OH_Heavy_Attack_01 && inputHandler.la_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_02, true);
                    lastAttack = weapon.OH_Light_Attack_02;
                }
                if (lastAttack == weapon.OH_Heavy_Attack_01 && inputHandler.ha_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_02, true);
                    lastAttack = weapon.OH_Heavy_Attack_02;
                }
                if (lastAttack == weapon.OH_Heavy_Attack_02 && inputHandler.la_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_01, true);
                    lastAttack = weapon.OH_Light_Attack_01;
                }
                if (lastAttack == weapon.OH_Heavy_Attack_02 && inputHandler.ha_Input == true)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_01, true);
                    lastAttack = weapon.OH_Heavy_Attack_01;
                }
            }
        }
        public void HandleLightAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_01, true);
            lastAttack = weapon.OH_Light_Attack_01;
        }
        public void HandleHeavyAttack(WeaponItem weapon)
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_01, true);
            lastAttack = weapon.OH_Heavy_Attack_01;
        }
    }
}
