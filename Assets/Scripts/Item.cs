using System;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType {

    Meat,
    Grass


}
[System.Serializable]
public class Item
{
   
    public ItemType itemType;
    public Sprite itemSprite;
 

}

