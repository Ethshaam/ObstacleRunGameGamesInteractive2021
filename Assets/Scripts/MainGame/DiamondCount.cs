using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondCount : MonoBehaviour
{
    // Start is called before the first frame update

    //Coin gem  text field
    [SerializeField] private TextMeshProUGUI diamondText; //drag it into inspector


    [SerializeField] public int points;

    public void DiamondScore(int scoreToAdd)
    {
        Debug.Log("ADDING Points to the player!");
        points += scoreToAdd;

        diamondText.text = "Diamond: " + points.ToString();
    }

}

