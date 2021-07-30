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
        WeaponSlotManager weaponSlotManager;

        public AudioSource playerAudio;
        public AudioClip[] _damage;
        public AudioClip[] _death;

        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            playerManager = GetComponent<PlayerManager>();
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
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
            if (!playerAudio.isPlaying)
            {
                playerAudio.PlayOneShot(_damage[Random.Range(0, 1)]);
            }

            if (!weaponSlotManager.isHyperArmored)
            { 
                animatorHandler.PlayTargetAnimation("Flinch", true);
            }
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animatorHandler.PlayTargetAnimation("Death_01", true);
                playerAudio.PlayOneShot(_death[Random.Range(0, _death.Length)]);
                isDead = true;
            }      
        }
        public void TakeDamageKnockdown(int damage)
        {
            if (playerManager.isInvulnerable)
                return;
            if (isDead)
                return;
            currentHealth = currentHealth - damage;
            playerAudio.PlayOneShot(_damage[Random.Range(2, 3)]);
            healthBar.SetCurrentHealth(currentHealth);
            
            if(!weaponSlotManager.isHyperArmored)
            {
                animatorHandler.PlayTargetAnimation("Knockdown", true);
            }

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animatorHandler.PlayTargetAnimation("Death_01", true);
                playerAudio.PlayOneShot(_death[Random.Range(0, _death.Length)]);
                isDead = true;
            }
        }
        public void HealPlayer(int healAmount)
        {
            currentHealth = currentHealth + healAmount;

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            healthBar.SetCurrentHealth(currentHealth);
        }

    }
}
