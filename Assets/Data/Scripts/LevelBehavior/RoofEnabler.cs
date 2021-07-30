using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS {
    public class RoofEnabler : MonoBehaviour
    {
        public GameObject levelRoof;

        private void Awake()
        {
            levelRoof.SetActive(true);
        }
    }
}