using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    [CreateAssetMenu(menuName = "Items/Consumables/Flasks")]
    public class FlaskItem : ConsumableItem
    {

        [Header("Flask type")]
        public bool healingFlask;
        public bool stamFlask;
        public bool magicFlask;

        [Header("Recovery Amount")]
        public int healthRecoveryAmount;
        public int staminaRecoveryAmount;
        public int magicRecoveryAmount;

        [Header("Recovery FX")]
        public GameObject recoveryFX;

        public override void AttemptToUseConsumableItem(AnimatorManager animatorManager, WeaponSlotManager weaponSlotManager, PlayerEffectsManager playerEffectsManager)
        {
            base.AttemptToUseConsumableItem(animatorManager, weaponSlotManager, playerEffectsManager);
            GameObject flask = Instantiate(itemModel, weaponSlotManager.rightHandSlot.transform);
            playerEffectsManager.currentParticleFX = recoveryFX;
            playerEffectsManager.amountToBeHealed = healthRecoveryAmount;
            playerEffectsManager.instantiatedFXModel = flask;
            weaponSlotManager.rightHandSlot.UnloadWeapon();
            currentItemAmount = currentItemAmount - 1;
            if (currentItemAmount <= 0)
            {
                currentItemAmount = 0;
            }
        }
    }
}
