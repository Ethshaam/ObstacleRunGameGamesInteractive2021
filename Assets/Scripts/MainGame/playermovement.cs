using System.Collections;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    //creating a float variable so I can edit it in the inspector. 
    public float playerSpeed = 10000f;
    public float Sideways = 0f;
    public float jump = 0f;
    public float Gravity = 0f;

    //creating variables for the speed boost power up

    public float doubleSpeed = 20f;
    private float cachedPlayerSpeed = 10f;
    private float speedMultiplier = 2f;

    [SerializeField] private GameObject boostObject;

    //ienumator

    //double speed variable


    //creating variables for the double jump power up
    public float playerjump;


    // Start is called before the first frame update
    public bool PlayerOnGround = true;
    private object normalSpeed;

    // we marked this "fixed" update because we are using it to mess with physics

    private void Start()
    {

    }


 //   private void Awake()
  //  {
     //   cachedPlayerSpeed = playerSpeed;

   // }

    //private void OnTriggerEnter(Collider other)
   // {
      //  if (other.CompareTag("Player"))
      //  {
     //       playermovement player = other.GetComponent<>
    //    }
   //

   // private IEnumerator Speed()
   // {

     //   //soon as you hit the power up, run this coroutine.
      //  if (gameObject.name == "Player")
    //    {
    
      //  }
       // Debug.Log("The player now has double speed");
       // playerSpeed = cachedPlayerSpeed * speedMultiplier;

       // yield return new WaitForSeconds(5);
       // Destroy(boostObject);
       // Debug.Log("The players speed has gone back to normal");
       // playerSpeed = cachedPlayerSpeed;
    //}






    void FixedUpdate()
    {
        //add a forward force

        rb.AddForce(0, 0, playerSpeed * Time.deltaTime);

        //ending the game if an object has been hit 
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


        if (Input.GetKey("d"))
        {
            Debug.Log("right");
            //right
            rb.AddForce(new Vector3(Sideways * Time.deltaTime, 0, 0), ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            //left
            Debug.Log("left");
            rb.AddForce(new Vector3(-Sideways * Time.deltaTime, 0, 0), ForceMode.VelocityChange);


        }


        if (Input.GetKey("w") && PlayerOnGround)
        {
            //jump
            Debug.Log("Jump");
            rb.AddForce(new Vector3(0, jump * Time.deltaTime, 0), ForceMode.Impulse);
            PlayerOnGround = false;
        }

        if (Input.GetKey("s"))
        {
            //jump
            Debug.Log("roll");
            rb.AddForce(new Vector3(0,
                                    -jump * Time.deltaTime,
                                    0), ForceMode.Impulse);
            PlayerOnGround = false;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            PlayerOnGround = true;


        }




    }
}







