using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;    // Referance to the rigidbody component called "rb"

    public float forwardForce = 5000f;
    public float siedwaysForce = 500f;

    //private float ScreenWidth;

    void Start()
    {
        //ScreenWidth = Screen.width;
        Debug.Log(Screen.width);
    }

    void FixedUpdate()  // Fixed Update is better for physics stuff
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   // Adding  a forward force to player object each frame 

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            //Moves right
            rb.AddForce( siedwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Debug.Log("Moving Right");
        }

        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            //Moves left
            rb.AddForce(-siedwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Debug.Log("Moving Left");
        }
        //THIS IS LEGACY CODE FOR MOBILE USE
        //int i = 0;
        //loop over every touch found
        /*while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                //move right
                rb.AddForce(-siedwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("moving right");
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                //move left
                rb.AddForce(siedwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("moving left");
            }
            ++i;
        }*/
        if (rb.position.y < -1.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
