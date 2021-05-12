using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Pathfinding;

public class OptionScript : MonoBehaviour
{
    [SerializeField] GameObject dino;
    [SerializeField] Collider2D collider;
    Item item;

    [SerializeField] AnimController animController;
    private void Awake()
    {
        dino = GameObject.FindWithTag("Player");
        collider = GetComponent<Collider2D>();
        dino.GetComponent<AIDestinationSetter>().target = transform;
        animController = FindObjectOfType<AnimController>();
        animController.Walk(true);
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
