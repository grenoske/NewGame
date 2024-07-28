using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public Sprite Icon;
    [TextArea] 
    public string Description;

    public int StartingAmmo;
    public int StartingCondition;
    
}
