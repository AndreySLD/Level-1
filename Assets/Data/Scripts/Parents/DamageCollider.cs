using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class DamageCollider : MonoBehaviour
    {
        Collider damageCollider;

        public int currentWeaponDamage = 25;

        [HideInInspector]
        public bool KnockDown;
        public bool alwaysKnockDown;
        public bool ragdoll;


        private void Awake()
        {
            damageCollider = GetComponent<Collider>();
            damageCollider.gameObject.SetActive(true);
            damageCollider.isTrigger = true;
            damageCollider.enabled = false;
        }
        public void EnableDamageCollider()
        {
            damageCollider.enabled = true;
        }
        public void DisableDamageCollider()
        {
            damageCollider.enabled = false;
        }
        public void EnableKnockdown()
        {
            KnockDown = true;
        }
        public void DisableKnockDown()
        {
            KnockDown = false;
        }
        private void OnTriggerEnter(Collider collision)
        {
            if (collision.tag == "Player" && GetComponentInParent<EnemyStats>())
            {
                PlayerStats playerStats = collision.GetComponent<PlayerStats>();

                if (playerStats != null && alwaysKnockDown == true || KnockDown == true)
                {
                    playerStats.TakeDamageKnockdown(currentWeaponDamage);
                }
                else if (playerStats != null && alwaysKnockDown == false && KnockDown == false)
                {
                    playerStats.TakeDamage(currentWeaponDamage);
                }
            }
            if (collision.tag == "Enemy" && GetComponentInParent<PlayerStats>() || (collision.GetComponentInParent<EnemyStats>() != GetComponentInParent<EnemyStats>()))
            {
                EnemyStats enemyStats = collision.GetComponent<EnemyStats>();

                if (enemyStats != null && !enemyStats.isDead && alwaysKnockDown == true || KnockDown == true)
                {
                    enemyStats.TakeDamageKnockdown(currentWeaponDamage); 
                }
                else if (enemyStats != null && !enemyStats.isDead && alwaysKnockDown == false && KnockDown == false)
                {
                    enemyStats.TakeDamage(currentWeaponDamage);
                }
            }
        }
    }
}
