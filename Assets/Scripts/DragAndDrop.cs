using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Pathfinding;

public class DragAndDrop : MonoBehaviour,IPointerDownHandler,IDropHandler,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    Vector2 defaultPos;
    [SerializeField] AIDestinationSetter target;
    
    [SerializeField] GameObject optionWorld;
    //Action action;
    public Item item;
    GameObject optionHolder;
    GameObject foodHolder;
    private void Awake()
    {
        optionHolder = transform.parent.gameObject;  
        canvas = FindObjectOfType<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
        
        transform.SetParent(canvas.transform);
        defaultPos = transform.position;
        var temp = Instantiate(gameObject, optionHolder.transform);
        temp.transform.SetParent(optionHolder.transform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnDrop(PointerEventData eventData)
    {
        DestroyPreviousFood();
        var temp= Instantiate(optionWorld, transform);
        temp.transform.parent = null;
        temp.transform.position=new Vector3(temp.transform.position.x, temp.transform.position.y, 0);
        temp.GetComponent<OptionScript>().InitialiseOptionWorld(item);

        

        Destroy(gameObject);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       
        
    }

    public void InitialiseOption(Item item) {

        this.item = item;

    }

    public void DestroyPreviousFood() {

        var food = GameObject.FindGameObjectsWithTag("Food");
        if (food.Length < 1)
        { Debug.Log("No food"); }
        foreach (var item in food)
        {
            Destroy(item);
        }
    }
    
}
