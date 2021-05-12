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
    private void Awake()
    {
        
        canvas = FindObjectOfType<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        defaultPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnDrop(PointerEventData eventData)
    {
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
        Instantiate(gameObject);
        
    }

    public void InitialiseOption(Item item) {

        this.item = item;

    }
    
}
