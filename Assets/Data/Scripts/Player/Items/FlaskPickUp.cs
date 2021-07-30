using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class FlaskPickUp : MonoBehaviour
    {
        PlayerInventory playerInventory;
        public GameObject flaskModel;

        private void OnTriggerEnter(Collider other)
        {
            playerInventory = other.GetComponentInChildren<PlayerInventory>();
            if (playerInventory.currentCunsumable.currentItemAmount < playerInventory.currentCunsumable.maxItemAmount)
            {
                playerInventory.currentCunsumable.currentItemAmount = playerInventory.currentCunsumable.currentItemAmount + 1;
                Destroy(flaskModel);
            }
        }
    }
}
