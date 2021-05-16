using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DinoController : MonoBehaviour
{
    AnimController animController;
    // Start is called before the first frame update

    Collider2D collider;

    [SerializeField] ItemType dinotype;
    [SerializeField] GameObject likeEffect;
    [SerializeField] Transform optionPanel;

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
                likeEffect.SetActive(true);
            }
            else {
                animController.Dislike();
            }
            
            Destroy(food);
        }
    }

    public void DisableOption(){

        foreach (Transform item in optionPanel)
        {
           var temp2= item.GetChild(0).GetComponent<Image>();
           var temp= item.GetComponent<Image>();
            temp2.raycastTarget = false;
            temp2.color = Color.black;
        }

    }
    public void EnableOption()
    {

        foreach (Transform item in optionPanel)
        {
            var temp2 = item.GetChild(0).GetComponent<Image>();
            var temp = item.GetComponent<Image>();
            temp2.raycastTarget = true;
            temp2.color = Color.white;
        }

    }

}
