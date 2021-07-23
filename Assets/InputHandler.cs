using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS
{
    public class InputHandler : MonoBehaviour
    {
        public float horizontal;
        public float vertical;
        public float moveAmount;
        public float mouseX;
        public float mouseY;
        
        public bool B_Input;
        public bool la_Input;
        public bool ha_Input;
        public bool lockOn_Input;
        public bool LockOnRight_Input;
        public bool LockOnLeft_Input;
        public bool jump_Input;
        
        public bool rollFlag;
        public bool sprintFlag;
        public bool comboFlag;
        public bool lockOnFlag;
        
        public float rollInputTimer;

        PlayerControls inputActions;
        PlayerAttacker playerAttacker;
        PlayerInventory playerInventory;
        PlayerManager playerManager;
        CameraHandler cameraHandler;

        Vector2 movementInput;
        Vector2 cameraInput;

        private void Awake()
        {
            playerAttacker = GetComponent<PlayerAttacker>();
            playerInventory = GetComponent<PlayerInventory>();
            playerManager = GetComponent<PlayerManager>();
            cameraHandler = FindObjectOfType<CameraHandler>();
        }
        public void OnEnable()
        {
            if (inputActions == null)
            {
                inputActions = new PlayerControls();
                inputActions.PlayerMovement.Movement.performed += inputActions => movementInput = inputActions.ReadValue<Vector2>();
                inputActions.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
                inputActions.PlayerMovement.LockOnRight.performed += i => LockOnRight_Input = true;
                inputActions.PlayerMovement.LockOnLeft.performed += i => LockOnLeft_Input = true;
            }

            inputActions.Enable();
        }
        private void OnDisable()
        {
            inputActions.Disable();
        }

        public void TickInput(float delta)
        {
            HandleMoveInput(delta);
            HandleRollInput(delta);
            HandleAttackInput(delta);
            HandleJumpInput();
            HandleLockOnInput();
        }
        private void HandleMoveInput(float delta)
        {
            horizontal = movementInput.x;
            vertical = movementInput.y;
            moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical));
            mouseX = cameraInput.x;
            mouseY = cameraInput.y;
        }
        private void HandleRollInput(float delta)
        {
            B_Input = inputActions.PlayerActions.Roll.phase == UnityEngine.InputSystem.InputActionPhase.Started;
            
            if (B_Input)
            {
                rollInputTimer += delta;
                sprintFlag = true;
            }
            else
            {
                if (rollInputTimer > 0 && rollInputTimer < 0.5f)
                {
                    sprintFlag = false;
                    rollFlag = true;
                }

                rollInputTimer = 0;
            }
        }
        private void HandleAttackInput(float delta)
        {
            inputActions.PlayerActions.LightAttack.performed += i => la_Input = true;
            inputActions.PlayerActions.HeavyAttack.performed += i => ha_Input = true;

            if (la_Input)
            {
                if (playerManager.canCombo == true)
                {
                    comboFlag = true;
                    playerAttacker.HandleWeaponCombo(playerInventory.rightHandedWeapon);
                    comboFlag = false;
                }
                else
                {
                    if (playerManager.IsInteracting == true)
                    {
                        return;
                    }
                    if (playerManager.canCombo == true)
                    {
                        return;
                    }
                    playerAttacker.HandleLightAttack(playerInventory.rightHandedWeapon);
                }
            }
            if (ha_Input)
            {
                if (playerManager.canCombo == true)
                {
                    comboFlag = true;
                    playerAttacker.HandleWeaponCombo(playerInventory.rightHandedWeapon);
                    comboFlag = false;
                }
                else
                {
                    if (playerManager.IsInteracting == true)
                    {
                        return;
                    }
                    if (playerManager.canCombo == true)
                    {
                        return;
                    }
                    playerAttacker.HandleHeavyAttack(playerInventory.rightHandedWeapon);
                }
            }
        }
        private void HandleLockOnInput()
        {
            inputActions.PlayerActions.LockOn.performed += i => lockOn_Input = true;

            if (lockOn_Input && lockOnFlag == false)
            {
                lockOn_Input = false;
                cameraHandler.HandleLockOn();
                if (cameraHandler.nearestLockOnTarget != null)
                {
                    cameraHandler.currentLockOnTarget = cameraHandler.nearestLockOnTarget;
                    lockOnFlag = true;
                }
            }
            else if (lockOn_Input && lockOnFlag)
            {
                lockOn_Input = false;
                lockOnFlag = false;
                cameraHandler.ClearLockOn();
            }
            if (lockOnFlag && LockOnLeft_Input)
            {
                LockOnLeft_Input = false;
                cameraHandler.HandleLockOn();
                if (cameraHandler.leftLockTarget != null)
                {
                    cameraHandler.currentLockOnTarget = cameraHandler.leftLockTarget;
                }
            }
            if (lockOnFlag && LockOnRight_Input)
            {
                LockOnRight_Input = false;
                cameraHandler.HandleLockOn();
                if (cameraHandler.rightLockTarget != null)
                {
                    cameraHandler.currentLockOnTarget = cameraHandler.rightLockTarget;
                }
            }
            cameraHandler.SetCameraHeight();
        }
        private void HandleJumpInput()
        {
            inputActions.PlayerActions.Jump.performed += i => jump_Input = true;
        }
    }
}
