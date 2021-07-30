using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class DoorHandler : MonoBehaviour
    {
        Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                animator.Play("OpeningDoor");
            }
        }

    }
}
