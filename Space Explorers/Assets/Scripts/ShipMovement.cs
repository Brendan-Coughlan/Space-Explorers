using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    Rigidbody2D shipRb;

    private PlayerInput playerInput;
    private InputAction movementAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        //movementAction = playerInput.SwitchCurrentActionMap("Ship");
        shipRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Keyboard.current.tKey.wasPressedThisFrame)
        {
            Debug.Log("T");
            shipRb.AddForce(200 * Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
