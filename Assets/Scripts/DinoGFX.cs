using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class DinoGFX : MonoBehaviour
{
    AIPath aiPath;

    Vector3 dinotransform;
    // Start is called before the first frame update
    void Start()
    {
        dinotransform = transform.localScale;
        aiPath = FindObjectOfType<AIPath>();
        
    }

    // Update is called once per frame
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
