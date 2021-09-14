using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AS
{
    public class RagdollHandler : MonoBehaviour
    {
        private Rigidbody[] Rbs;
        private Collider[] Colls;

        public float KillForce = 5f;

        private Animator anim;
        public NavMeshAgent AI;

        void Start()
        {
            anim = GetComponentInChildren<Animator>();
            Rbs = GetComponentsInChildren<Rigidbody>();
            Colls = GetComponentsInChildren<Collider>();
            Revive();
        }
        public void SetRagdoll(bool active)
        {
            for (int i = 0; i < Rbs.Length; i++)
            {
                Rbs[i].isKinematic = !active;
                if (active)
                {
                    Rbs[i].AddForce(Vector3.forward * KillForce, ForceMode.Impulse);
                }
            }
            for (int i = 0; i < Colls.Length; i++)
            {
                Colls[i].enabled = active;
            }
        }


        public void SetMain (bool active)
        {
            anim.enabled = active;
            AI.enabled = active;
            Rbs[0].isKinematic = !active;
            Colls[0].enabled = active;
        }
        public void Kill()
        {
            SetRagdoll(true);
            SetMain(false);
        }
        public void Revive()
        {
            SetRagdoll(false);
            SetMain(true);
        }
    }
}
