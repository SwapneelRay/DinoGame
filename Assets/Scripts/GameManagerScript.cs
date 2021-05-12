using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pathfinding;

public class GameManagerScript : MonoBehaviour
{

    [SerializeField] ItemAssets itemAssets;

    [SerializeField] GameObject option;
    [SerializeField] GameObject Dinosaur;
    [SerializeField] AIDestinationSetter target;
    [SerializeField] GameObject placeholder;
    [SerializeField] Transform panel;
    [SerializeField] GameObject likeEffect;


    // Start is called before the first frame update
    void Start()
    {InstantiateOptions(itemAssets.items);
      GameSet();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameSet() {

        

    }


    void InstantiateOptions(List<Item> itemAssets) {

        foreach (var item in itemAssets)
        {
            var temp = Instantiate(option, panel);
            temp.transform.SetParent(panel);
            temp.GetComponent<Image>().sprite = item.itemSprite;
            temp.GetComponent<DragAndDrop>().InitialiseOption(item);
        }

    }

    void InstantiateOptionWorld() {



    }

}
