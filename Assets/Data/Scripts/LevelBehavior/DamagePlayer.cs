using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class DamagePlayer : MonoBehaviour
    {
        public int damage;

        public bool canKnockdown;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                PlayerStats playerStats = other.GetComponent<PlayerStats>();

                if (playerStats != null && canKnockdown == true)
                {
                    playerStats.TakeDamageKnockdown(damage);
                }
                else if (playerStats != null && canKnockdown == false)
                {
                    playerStats.TakeDamage(damage);
                }
            }
            else if (other.tag == "Enemy")
            {
                EnemyStats enemyStats = other.GetComponent<EnemyStats>();

                if (enemyStats != null && canKnockdown == true)
                {
                    enemyStats.TakeDamageKnockdown(damage);
                }
                else if (enemyStats != null && canKnockdown == false)
                {
                    enemyStats.TakeDamage(damage);
                }
            }
        }
    }
}
