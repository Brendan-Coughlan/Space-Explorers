using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    Image inventoryUI;

    Slot selectedSlot;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        
        if(hit.collider != null)
        {
            if(hit.transform.GetComponent<Slot>() != null)
                selectedSlot = hit.transform.GetComponent<Slot>();
        }


    }

    private void OpenInventory()
    {

    }
}
