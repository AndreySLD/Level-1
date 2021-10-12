using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class Item : ScriptableObject
    {
        [Header("Item")]
        public Sprite itemIcon;
        public string itemName;
    }
}
