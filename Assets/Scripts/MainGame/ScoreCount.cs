using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{

    //Coin gem  text field
    [SerializeField] private TextMeshProUGUI scoreText; //drag it into inspector
                                                        

    [SerializeField] public int points;

    public void GemScore(int scoreToAdd)
    {
        Debug.Log("ADDING Points to the player!");
        points += scoreToAdd;

        scoreText.text = "Gem: " + points.ToString();
    }

}




