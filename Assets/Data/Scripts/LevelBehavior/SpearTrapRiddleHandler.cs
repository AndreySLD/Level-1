using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class SpearTrapRiddleHandler : MonoBehaviour
    {
        public GameObject spearTrap;

        private void Awake()
        {
            spearTrap.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            spearTrap.SetActive(true);
        }
    }
}
