using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Item
{
    string displayName;
    string itemID;
    int stackLimit;

    public Item(string displayName, string itemID, int stackLimit3)
    {
        this.displayName = displayName; 
        this.itemID = itemID;
        this.stackLimit = stackLimit3;
    }

    public string getDisplayName()
    {
        return displayName;
    }

    public string getItemID()
    {
        return itemID;
    }

    public int getStackLimt()
    {
        return stackLimit;
    }
}
