using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FoodList : MonoBehaviour
{
    public List<string> foodList;
    public Text listText;

    public void checkFoodInList (string foodName)
    {
        if (foodList.Contains(foodName))
        {
            listText.text = "";
            foodList.Remove(foodName);
            foreach (string name in foodList)
            {
                listText.text = name + '\n';
            }

        }
        else
        {
            addFood(foodName);
        }
    }


    public void addFood(string foodName)
    {
        listText.text = "";
        foodList.Add(foodName);

        foreach (string name in foodList)
        {
            listText.text += name + '\n';   
        }
    }
}
