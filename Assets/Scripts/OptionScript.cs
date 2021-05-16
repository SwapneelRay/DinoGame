using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Pathfinding;

public class OptionScript : MonoBehaviour
{
    
    [SerializeField] Collider2D collider;
    Item item;
    [SerializeField] GameObject optHandler;
    
    private void Awake()
    {

        optHandler = GameObject.FindGameObjectWithTag("OptionPanel"); 

       
        optHandler.GetComponent<OptionPanelScript>().SetDestination(this.transform);
;        
        
        
    }

   
    public void InitialiseOptionWorld(Item item)
    {

        this.item = item;
        transform.GetComponent<SpriteRenderer>().sprite = item.itemSprite;


    }

    public ItemType FoodCheck() {

        return item.itemType;

    }
}
