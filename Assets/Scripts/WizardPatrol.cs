//Ryan Kawano
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardPatrol : MonoBehaviour
{
	public float speed;
	public bool movingRight;
	//public Transform groundDetection;
	public Transform stompDetection;
	public Transform wallDetectionRight;
	//public Transform wallDetectionLeft;
	public Rigidbody2D rb;
	//public static AudioClip deathSound;
	public AudioSource audioSrc;
	//public float idleTime;
	//public float currentIdleTime;
	//public bool isIdle;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        movingRight = true;

        audioSrc = GetComponent<AudioSource>();
        /*
        idleTime = 2f;
        currentIdleTime = 0;
        isIdle = true;*/
    }

    // Update is called once per frame
    void Update()
    {
    	/*************************
    	Frog Movement
    	*************************/
        transform.Translate(Vector2.right * speed * Time.deltaTime); //Frog moves right

        //RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 1f);
        RaycastHit2D wallInfoRight = Physics2D.Raycast(wallDetectionRight.position, Vector2.right, 1f);
        //RaycastHit2D wallInfoLeft = Physics2D.Raycast(wallDetectionLeft.position, Vector2.left, 1f);

        if(/*groundInfo.collider == false || */wallInfoRight.collider == true /*|| wallInfoLeft.collider == true*/) //If false then character should move in opposite direction. False means no ground below.
        {
        	if(movingRight == true) //If enemy was moving right
        	{
        		transform.eulerAngles = new Vector3(0, -180, 0); //New direction (left)
        		movingRight = false; //Update movingRight
        	}
        	else //The enemy wasn't moving right
        	{
        		transform.eulerAngles = new Vector3(0, 0, 0); //New direction (right)
        		movingRight = true; //Update movingRight
        	}
        }


        /*************************
    	Stomp
    	*************************/
        RaycastHit2D stompInfo = Physics2D.Raycast(stompDetection.position, Vector2.up, .01f);

        if(stompInfo.collider == true) //If fox is on enemy's head
        {
        	//audioSrc.Play(); //Play death sound
        	Destroy(gameObject); //Destroys enemy
        }

        /*if(isIdle)
        {
        	currentIdleTime += Time.deltaTime;
        	if(currentIdleTime >= idleTime)
        	{
        		currentIdleTime = 0;
        		transform.Translate(Vector2.up * Time.deltaTime * 300 );
        		Jump();
        	}
        }*/
    }

    /*void Jump()
    {
    	isJumping = true;
    	isIdle = false;

    	rb.velocity = new Vector2(0, 3f);
    }*/
}

