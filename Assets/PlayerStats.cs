using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS 
{
    public class PlayerStats : CharacterStats
    {
        public HealthBar healthBar;

        AnimatorHandler animatorHandler;
        PlayerManager playerManager;

        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            playerManager = GetComponent<PlayerManager>();
        }

        private void Start()
        {
            maxHealth = SetMaxHealthFromLeathLevelFormula();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }

        private int SetMaxHealthFromLeathLevelFormula()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }
        public void TakeDamage(int damage)
        {
            if (playerManager.isInvulnerable)
                return;
            if (isDead)
                return;
            currentHealth = currentHealth - damage;
            healthBar.SetCurrentHealth(currentHealth);

            if (damage >= 30)
            { 
                animatorHandler.PlayTargetAnimation("Knockdown", true);
            } 
            else
            {
                animatorHandler.PlayTargetAnimation("Flinch", true);
            }

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animatorHandler.PlayTargetAnimation("Death_01", true);
                isDead = true;
            }      
        }
    }
}
