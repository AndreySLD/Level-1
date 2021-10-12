using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    [System.Serializable]
    public class PlayerData
    {
        public int health;
        public float[] position;

        public PlayerData (PlayerStats playerStats)
        {
            health = playerStats.currentHealth;

            position = new float[3];
            position[0] = playerStats.transform.position.x;
            position[1] = playerStats.transform.position.y;
            position[2] = playerStats.transform.position.z;
        }
    }
}
