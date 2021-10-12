using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AS
{
    public sealed class LevelFinish : Bonus
    {
        protected override void Interaction()
        {
            PlayerInventory playerInventory = FindObjectOfType<PlayerInventory>();
            if (playerInventory.keyCount == 4)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
