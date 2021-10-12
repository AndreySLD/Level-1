using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AS
{
    public class FlaskAmount : MonoBehaviour
    {
        ConsumableItem currentCunsumable;

        public Text text;
        public PlayerInventory playerInventory;

        private void Update()
        {
            currentCunsumable = playerInventory.currentCunsumable;
            text.text = currentCunsumable.currentItemAmount.ToString();
        }
    }
}
