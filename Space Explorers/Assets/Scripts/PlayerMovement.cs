using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public int walkSpeed;
    private Vector2 movementInput;

    private PlayerInput playerInput;
    private InputAction movementAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        movementAction = playerInput.actions["Movement"];
    }

    private void FixedUpdate()
    {
        movementInput = movementAction.ReadValue<Vector2>();
        transform.Translate(movementInput.normalized * walkSpeed * Time.deltaTime);
    }
}
