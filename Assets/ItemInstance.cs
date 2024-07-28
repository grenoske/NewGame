using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInstance 
{
    public ItemData ItemType;
    public int Condition;
    public int Ammo;

    public ItemInstance(ItemData itemData)
    {
        ItemType = itemData;
        Condition = itemData.StartingCondition;
        Ammo = itemData.StartingAmmo;
    }
}
