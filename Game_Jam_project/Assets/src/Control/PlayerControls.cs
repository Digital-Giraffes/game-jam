using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

namespace control
{
  public class PlayerControls : MonoBehaviour
  {
    [SerializeField] private model.GameModel _player_model;

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
      var movement = context.ReadValue<Vector2>();
      if (Math.Abs(movement.x) > Math.Abs(movement.y))
      {
        _player_model.Move(Math.Sign(movement.x) * Vector2.right);
      }
      else if (Math.Abs(movement.x) < Math.Abs(movement.y))
      {
        _player_model.Move(Math.Sign(movement.y) * Vector2.up);
      }
    }

    private void OnMovementCancelled(InputAction.CallbackContext context)
    {
      _player_model.Move(Vector2.zero);
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
