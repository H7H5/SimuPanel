using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType 
{ 
    Default, Tools, Component
}
public class ItemScriptableObject : ScriptableObject
{
    public string ItemName;
    public int MaxAmount;
    public GameObject ItemPrefab;
    public Sprite Icon;
    public ItemType ItemType;
}
