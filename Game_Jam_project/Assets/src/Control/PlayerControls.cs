using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace control
{
  public class PlayerControls : MonoBehaviour
  {
    [SerializeField] private model.PlayerModel _player_m;

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
      _player_m.SetMoveDirection(context.ReadValue<Vector2>());
    }

    private void OnMovementCancelled(InputAction.CallbackContext context)
    {
      _player_m.SetMoveDirection(Vector2.zero);
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
    }

    private void OnDisableInput()
    {
      _input.Player.Movement.performed -= OnMovementPerfomed;
      _input.Player.Movement.canceled -= OnMovementCancelled;
    }
  }
}
