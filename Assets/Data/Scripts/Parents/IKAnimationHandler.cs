using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class IKAnimationHandler : MonoBehaviour
    {
        Animator animator;
        CameraHandler cameraHandler;

        private void Start()
        {
            animator = GetComponent<Animator>();
            cameraHandler = FindObjectOfType<CameraHandler>();
        }
        private void OnAnimatorIK(int layerIndex)
        {
            if (cameraHandler.currentLockOnTarget != null)
            {
                animator.SetLookAtWeight(1);
                animator.SetLookAtPosition(cameraHandler.currentLockOnTarget.transform.position);
            }
        }
    }
}
