using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField]
    int slotNum;
    Item currentItem;
    int itemCount;

    private void Start()
    {
        for(int i = 0; i < transform.parent.childCount; i++)
        {
            if (transform.parent.GetChild(i).Equals(this.transform))
                slotNum = i;
        }
    }

    public void setCurrentItem(Item newItem)
    {
        currentItem = newItem;
    }

    public Item getCurrentItem()
    {
        return currentItem;
    }

    public void setItemCount(int newItemCount)
    {
        itemCount = newItemCount;
    }

    public int getItemCount()
    {
        return itemCount;
    }
}
