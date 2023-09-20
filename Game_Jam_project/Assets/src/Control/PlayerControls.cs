using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace control
{
  public class PlayerControls : MonoBehaviour
  {
    [SerializeField] private model.PlayerModel _player_model;

    private CustomInput _input = null;

    private void Awake()
    {
      _input = new CustomInput();
    }

    private void EnableInput()
    {
      _input.Enable();
      OnEnableInput();
    }

    private void DisableInput()
    {
      _input.Disable();
      OnDisableInput();
    }

    // ============================= Actions =============================

    private void OnMovementPerfomed(InputAction.CallbackContext context)
    {
      _player_model.SetMoveDirection(context.ReadValue<Vector2>());
    }

    private void OnMovementCancelled(InputAction.CallbackContext context)
    {
      _player_model.SetMoveDirection(Vector2.zero);
    }

    private void OnEyesPerformed(InputAction.CallbackContext context)
    {
      _player_model.OpenEyes();
    }

    private void OnEyesCancelled(InputAction.CallbackContext context)
    {
      _player_model.CloseEyes();
    }

    // ============================= Callbacks =============================

    private void OnEnable()
    {
      EnableInput();
    }

    private void OnDisable()
    {
      DisableInput();
    }

    private void OnEnableInput()
    {
      _input.Player.Movement.performed += OnMovementPerfomed;
      _input.Player.Movement.canceled += OnMovementCancelled;
      _input.Player.Eyes.performed += OnEyesPerformed;
      _input.Player.Eyes.canceled += OnEyesCancelled;
    }

    private void OnDisableInput()
    {
      _input.Player.Movement.performed -= OnMovementPerfomed;
      _input.Player.Movement.canceled -= OnMovementCancelled;
      _input.Player.Eyes.performed -= OnEyesPerformed;
      _input.Player.Eyes.canceled -= OnEyesCancelled;
    }
  }
}
