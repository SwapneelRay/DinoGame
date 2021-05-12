﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class DinoGFX : MonoBehaviour
{
    AIPath aiPath;

    // Start is called before the first frame update
    void Start()
    {
        aiPath = FindObjectOfType<AIPath>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f) {
            transform.localScale = new Vector3(-0.45864f, 0.45864f, 0.45864f);
        }
        else if(aiPath.desiredVelocity.x <= -0.01f){
            transform.localScale = new Vector3(0.45864f, 0.45864f, 0.45864f);
        }
    }
}
