using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class OptionPanelScript : MonoBehaviour
{
    [SerializeField] GameObject dino;
    [SerializeField] Transform target;
 
    // Start is called before the first frame update
    void Start()
    {
        dino = GameObject.FindWithTag("Player");
        
    }

   

    public void SetDestination(Transform t) {

        dino.GetComponentInChildren<AnimController>().Walk(true);
        dino.GetComponent<AIDestinationSetter>().target=t;
    }
}
