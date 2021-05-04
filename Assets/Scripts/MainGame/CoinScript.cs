using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private GameObject Gems;
    
    // Start is called before the first frame update
    void Start()
    {
       //scoreText.text = "Gem: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("the object should be destroyed");
            //adding one point to the score. 
            other.GetComponent<ScoreCount>().GemScore(1);
            

            //Destroying the game object once its been hit
            Destroy(Gems);
           
        }
    }
}
