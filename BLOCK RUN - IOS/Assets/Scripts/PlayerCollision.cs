using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Ew vars
    public Rigidbody rb;    // Referance to the rigidbody component called "rb"
    public float jumpForce = 500f;
    public float pushForce;
    public PlayerMovement movement;

    // Jump Sound Stuff
    public GameObject jumpObject;
    private AudioSource jumpSound;

    // Death Sound Stuff
    public GameObject deathObject;
    private AudioSource deathSound;

    // Music Sound Stuff
    public GameObject musicObject;
    private AudioSource musicSound;

    void Awake ()   // Grabbing all the right gameObjects
    {
        jumpSound = jumpObject.GetComponent<AudioSource>();
        deathSound = deathObject.GetComponent<AudioSource>();
        musicSound = musicObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")   // If the player collides with an obstacle
        {
            deathSound.enabled = true;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            musicSound.enabled = false;
        }

        if (collisionInfo.collider.tag == "Jump")   // If the player collides with a jump pad
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, pushForce, ForceMode.VelocityChange);
            jumpSound.enabled = true;
            Invoke("TurnOffJump", 1);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jump"))   // If the player collides with a jump pad
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            jumpSound.enabled = true;
            Invoke("TurnOffJump", 1);
        }
    }

    void TurnOffJump()  //For invoking
    {
        jumpSound.enabled = false;
    }
}