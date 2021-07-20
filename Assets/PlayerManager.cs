using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator anim;
        CameraHandler cameraHandler;
        PlayerLocomotion playerLocomotion;

        [Header("Player Flags")]
        public bool IsInteracting;
        public bool IsSprinting;
        public bool IsInTheAir;
        public bool IsGrounded;
        public void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            anim = GetComponentInChildren<Animator>();
            cameraHandler = CameraHandler.singleton;
            playerLocomotion = GetComponent<PlayerLocomotion>();
        }
        public void Update()
        {
            IsInteracting = anim.GetBool("IsInteracting");

            float delta = Time.deltaTime;
            inputHandler.TickInput(delta);
            playerLocomotion.HandleMovement(delta);
            playerLocomotion.HandleRollingAndSprinting(delta);
            playerLocomotion.HandleFalling(delta, playerLocomotion.moveDirection);
        }
        public void FixedUpdate()
        {
            float delta = Time.fixedDeltaTime;

            if (cameraHandler != null)
            {
                cameraHandler.FollowTarget(delta);
                cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
            }
        }
        private void LateUpdate()
        {
            inputHandler.rollFlag = false;
            inputHandler.sprintFlag = false;
            IsSprinting = inputHandler.B_Input;

            if (IsInTheAir)
            {
                playerLocomotion.InTheAirTimer = playerLocomotion.InTheAirTimer + Time.deltaTime;
            }
        }
    }
}
