using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosFood : MonoBehaviour
{
    public FoodList foodlist;
    private void OnMouseDown()
    {
        
        foodlist.checkFoodInList(gameObject.name);
    }
}
