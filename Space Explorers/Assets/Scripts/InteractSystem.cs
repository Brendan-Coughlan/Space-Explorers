using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class InteractSystem : MonoBehaviour
{
    public SpriteRenderer interactionPrompt;

    private PlayerInput playerInput;
    private InputAction interactionAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        interactionAction = playerInput.actions["Interact"];
    }

    private void Update()
    {
        Collider2D nearbyObject = Physics2D.OverlapCircle(transform.position, 1f);
        if (nearbyObject != null && nearbyObject.CompareTag("Interactable"))
        {
            interactionPrompt.transform.localPosition = transform.parent.GetChild(0).position + new Vector3(0, 0.8f, 0);
            interactionPrompt.enabled = true;
            if(interactionAction.triggered)
            {
                Debug.Log(nearbyObject.name + " has been interacted with");
            }
        }
        else
        {
            interactionPrompt.enabled = false;
        }
    }
}
