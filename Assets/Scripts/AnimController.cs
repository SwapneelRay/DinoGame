using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       anim= GetComponent<Animator>();
    }



    public void Like()
    {
        anim.SetTrigger(AnimTags.LIKE);
    }

    public void Walk(bool walk)
    {
        anim.SetBool(AnimTags.WALK, walk);
    }

    public void Eat()
    {
        anim.SetTrigger(AnimTags.EAT);
    }

    public void Dislike()
    {
        anim.SetTrigger(AnimTags.DISLIKE);
    }
}
