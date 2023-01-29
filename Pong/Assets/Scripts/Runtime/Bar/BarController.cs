using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace lgames
{
    public class BarController : MonoBehaviour
    {

        #region :: Variables
        [SerializeField] private BarHandler _barHandler;
        [SerializeField] private InputActionManager _inputActionManager;

        private bool _isMovingLeft = false;
        private bool _isMovingRight = false;
        #endregion

        #region :: Listeners
        private void OnEnable()
        {
            _inputActionManager.EventMoveLeft += OnMoveLeft;
            _inputActionManager.EventMoveRight += OnMoveRight;
        }

        private void OnDisable()
        {
            _inputActionManager.EventMoveLeft -= OnMoveLeft;
            _inputActionManager.EventMoveRight -= OnMoveRight;
        }
        #endregion

        #region :: Lifecycle
        private void Awake()
        {
            if (_inputActionManager == null)
            {
                _inputActionManager = FindObjectOfType<InputActionManager>();
            }
        }

        private void Start()
        {
            if (_barHandler == null)
            {
                _barHandler.GetComponentInParent<BarHandler>();
            }
        }

        private void Update()
        {
            if (_isMovingLeft && _isMovingRight)
            {
                return;
            } 
            else if (_isMovingLeft)
            {
                Move(Vector2.left);
            }
            else if (_isMovingRight)
            {
                Move(Vector2.right);
            }
        }
        #endregion

        #region :: Events
        private void OnMoveLeft(InputAction.CallbackContext callbackContext)
        {
            if (callbackContext.started)
            {
                _isMovingLeft = true;
            }

            if (callbackContext.canceled)
            {
                _isMovingLeft = false;
            }
        }

        private void OnMoveRight(InputAction.CallbackContext callbackContext)
        {
            if (callbackContext.started)
            {
                _isMovingRight = true;
            }

            if (callbackContext.canceled)
            {
                _isMovingRight = false;
            }
        }
        #endregion

        #region :: Actions

        #endregion

        #region :: Methods
        private void Move(Vector2 movement)
        {
            _barHandler.GetTransform().Translate(_barHandler.speed * Time.deltaTime * movement);
        }
        #endregion

        #region :: Enumerator 

        #endregion

    }
}
