using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AS
{
    public class LevelFinish : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
                if (playerInventory.keyCount == 4)
                {
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}
