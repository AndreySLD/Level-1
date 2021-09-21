using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public abstract class Bonus : MonoBehaviour
    {
        public bool isBonus { get; } = true;
        protected abstract void Interaction();

        private void OnTriggerEnter(Collider other)
        {
            if (!isBonus || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }
    }
}
