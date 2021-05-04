using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    [SerializeField] private GameObject Diamonds;

    // Start is called before the first frame update
    void Start()
    {
        //diamondText.text = "Gem: 0";
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
            other.GetComponent<DiamondCount>().DiamondScore(1);


            //Destroying the game object once its been hit
            Destroy(Diamonds);

        }
    }
}
