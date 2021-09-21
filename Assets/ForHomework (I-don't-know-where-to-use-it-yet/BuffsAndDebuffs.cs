using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class BuffsAndDebuffs : Bonus
    {
        public int _index;
        protected override void Interaction()
        {
            PlayerStats playerStats = FindObjectOfType<PlayerStats>();
            PlayerLocomotion playerLocomotion = FindObjectOfType<PlayerLocomotion>();

            if (tag == "Buff")
            {
                if (_index == 0)
                {
                    playerStats.HealPlayer(10);
                }
                else if (_index == 1)
                {
                    playerLocomotion.movementSpeed = playerLocomotion.movementSpeed + 5;
                    playerLocomotion.sprintSpeed = playerLocomotion.sprintSpeed + 5;
                    for (int i = 0; i < 20; i++)
                    {
                        playerLocomotion.movementSpeed = (float)(playerLocomotion.movementSpeed - 0.25);
                        playerLocomotion.sprintSpeed = (float)(playerLocomotion.sprintSpeed - 0.25);
                    }
                }
            }
            else if (tag == "Debuff")
            {
                if (_index == 0)                
                {
                    playerLocomotion.movementSpeed = playerLocomotion.movementSpeed - 5;
                    playerLocomotion.sprintSpeed = playerLocomotion.sprintSpeed - 5;
                    for (int i = 0; i < 20; i++)
                    {
                        playerLocomotion.movementSpeed = (float)(playerLocomotion.movementSpeed + 0.25);
                        playerLocomotion.sprintSpeed = (float)(playerLocomotion.sprintSpeed + 0.25);
                    }
                }
                else if (_index == 1)
                {
                    playerStats.TakeDamage(10);
                } 
            }
            else
            {
                return;
            }
        }

        List<string> Buffs = new List<string>
        {
            "Лечение",
            "Ускорение"
        };
        List<string> Debuffs = new List<string>
        {
            "Замедление",
            "Урон"
        };
    }
}
