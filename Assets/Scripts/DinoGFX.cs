using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class DinoGFX : MonoBehaviour
{
    AIPath aiPath;

    Vector3 dinotransform;
    
    void Start()
    {
        dinotransform = transform.localScale;
        aiPath = FindObjectOfType<AIPath>();
        
    }

   
    void Update()
    {

        if (aiPath.desiredVelocity.x >= 0.01f) {
            transform.localScale = new Vector3(-dinotransform.x, dinotransform.y, dinotransform.z);
        }
        else if(aiPath.desiredVelocity.x <= -0.01f){
            transform.localScale = new Vector3(dinotransform.x, dinotransform.y, dinotransform.z);
        }
    }
}
