using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class EnemyStats : CharacterStats
    {
        Animator animator;
        EnemyLocomotionManager enemyLocomotionManager;
        WeaponSlotManager weaponSlotManager;

        public UIEnemyHealthBar enemyHealthBar;


        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
            enemyLocomotionManager = GetComponent<EnemyLocomotionManager>();
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }

        private void Start()
        {
            maxHealth = SetMaxHealthFromLeathLevelFormula();
            currentHealth = maxHealth;
            enemyHealthBar.SetMaxHealth(maxHealth);
        }

        private int SetMaxHealthFromLeathLevelFormula()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }
        public void TakeDamage(int damage)
        {
            if (isDead)
            {
                return;
            }
            currentHealth = currentHealth - damage;
            enemyHealthBar.SetHealth(currentHealth);

            if (damage >= 30)
            {
                if (!weaponSlotManager.isHyperArmored) 
                { 
                    animator.Play("Knockdown"); 
                }
            }
            else
            {
                if (!weaponSlotManager.isHyperArmored) 
                {
                    animator.Play("Flinch"); 
                }
            }

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Death_01");
                isDead = true;
            }
        }
    }
}
