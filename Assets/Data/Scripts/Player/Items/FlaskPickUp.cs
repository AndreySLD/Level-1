using System;
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
            //playerInventory = other.GetComponentInChildren<PlayerInventory>();
            //try
            //{
            //    playerInventory.currentCunsumable.currentItemAmount += 1;
            //    if (playerInventory.currentCunsumable.currentItemAmount > playerInventory.currentCunsumable.maxItemAmount) throw new Exception();
            //}
            //catch
            //{
            //    Debug.Log(message: "Инвентарь переполнен");
            //    playerInventory.currentCunsumable.currentItemAmount -= 1;
            //    return;
            //}
            //Destroy(flaskModel);
            if (playerInventory.currentCunsumable.currentItemAmount < playerInventory.currentCunsumable.maxItemAmount)
            {
                playerInventory.currentCunsumable.currentItemAmount += 1;
                Destroy(flaskModel);
            }
        }
    }
}
