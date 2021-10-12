using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class EnemyStats : CharacterStats
    {
        Animator animator;

        public UIEnemyHealthBar enemyHealthBar;
        public GameObject LockOnTransform;

        WeaponSlotManager weaponSlotManager;
        EnemyLocomotionManager enemyLocomotionManager;
        RagdollHandler ragdollHandler;
        EnemyManager enemyManager;

        public AudioSource enemyAudio;
        public AudioClip[] _damage;
        public AudioClip[] _death;

        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
            enemyLocomotionManager = GetComponent<EnemyLocomotionManager>();
            ragdollHandler = GetComponent<RagdollHandler>();
            enemyManager = GetComponent<EnemyManager>();
        }

        private void Start()
        {
            maxHealth = SetMaxHealthFromLeathLevelFormula();
            currentHealth = maxHealth;
            enemyHealthBar.SetMaxHealth(maxHealth);
            ragdollHandler.Revive();
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
            if (!enemyAudio.isPlaying)
            {
                enemyAudio.PlayOneShot(_damage[Random.Range(0, 1)]);
            }
            
            if (!weaponSlotManager.isHyperArmored)
            {
                animator.Play("Flinch");
                enemyManager.isPerfromingAction = true;
                enemyManager.IsInteracting = true;
            }
            
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Death_01");
                isDead = true;
                enemyAudio.PlayOneShot(_death[Random.Range(0, _death.Length)]);
                enemyLocomotionManager.DisablingColliders();
                Destroy(LockOnTransform);                
            }
        }
        public void TakeDamageKnockdown(int damage)
        {
            if (isDead)
            {
                return;
            }
            currentHealth = currentHealth - damage;
            enemyAudio.PlayOneShot(_damage[Random.Range(2, 3)]);
            enemyHealthBar.SetHealth(currentHealth);
            
            if(!weaponSlotManager.isHyperArmored)
            {
                animator.Play("Knockdown");
                enemyManager.IsInteracting = true;
                enemyManager.isPerfromingAction = true;
            }

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                animator.Play("Death_01");
                isDead = true;
                enemyAudio.PlayOneShot(_death[Random.Range(0, _death.Length)]);
                enemyLocomotionManager.DisablingColliders();
                Destroy(LockOnTransform);
            }
        }
    }
}
