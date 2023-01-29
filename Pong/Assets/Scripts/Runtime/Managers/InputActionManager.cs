using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace lgames
{
    public class InputActionManager : Singleton
    {

        private InputConfig inputConfig;

        public delegate void ListenerMoveLeft(InputAction.CallbackContext callbackContext);
        public event ListenerMoveLeft EventMoveLeft;

        public delegate void ListenerMoveRight(InputAction.CallbackContext callbackContext);
        public event ListenerMoveRight EventMoveRight;

        private void Awake()
        {
            if (inputConfig == null)
            {
                inputConfig = new();
            }
        }

        private void OnEnable()
        {
            inputConfig.Enable();
        }

        private void OnDisable()
        {
            inputConfig.Disable();
        }

        private void Start()
        {
            inputConfig.KeyInput.MoveLeft.started += OnMoveLeft;
            inputConfig.KeyInput.MoveLeft.canceled += OnMoveLeft;

            inputConfig.KeyInput.MoveRight.started += OnMoveRight;
            inputConfig.KeyInput.MoveRight.canceled += OnMoveRight;
        }

        public void OnMoveLeft(InputAction.CallbackContext callbackContext) 
        {
            EventMoveLeft?.Invoke(callbackContext);
        }

        public void OnMoveRight(InputAction.CallbackContext callbackContext)
        {
            EventMoveRight?.Invoke(callbackContext);
        }

    }
}
