using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{
    AnimController animController;
    // Start is called before the first frame update

    Collider2D collider;

    [SerializeField] ItemType dinotype;

    void Start()
    {
        animController = GetComponent<AnimController>();
        collider = GetComponent<Collider2D>();

    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var food = collision.gameObject;
        if (food.tag == "Food") {
            animController.Walk(false);
            animController.Eat();

            if (food.GetComponent<OptionScript>().FoodCheck() == dinotype)
            {
                animController.Like();
            }
            else {
                animController.Dislike();
            }
            
            Destroy(food);
        }
    }

    public void InstantiateOption(){



    }
}
