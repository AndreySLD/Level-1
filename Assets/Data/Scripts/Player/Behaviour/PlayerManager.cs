using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class PlayerManager : CharacterManager
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
        public bool canCombo;
        public bool isInvulnerable;
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
            canCombo = anim.GetBool("canCombo");
            isInvulnerable = anim.GetBool("isInvulnerable");
            anim.SetBool("IsInTheAir", IsInTheAir);

            float delta = Time.deltaTime;
            inputHandler.TickInput(delta);
            playerLocomotion.HandleMovement(delta);
            playerLocomotion.HandleRollingAndSprinting(delta);
            playerLocomotion.HandleFalling(delta, playerLocomotion.moveDirection);
            playerLocomotion.HandleJumping();
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
            inputHandler.la_Input = false;
            inputHandler.ha_Input = false;
            inputHandler.jump_Input = false;
            inputHandler.lockOn_Input = false;
            inputHandler.kick_Input = false;
            inputHandler.rightHandSlot_Input = false;
            inputHandler.leftHandSlot_Input = false;
            inputHandler.magickSlot_Input = false;
            inputHandler.consumableSlot_Input = false;
            if (IsInTheAir)
            {
                playerLocomotion.InTheAirTimer = playerLocomotion.InTheAirTimer + Time.deltaTime;
            }
        }
    }
}
