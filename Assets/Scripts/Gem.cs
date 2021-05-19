//Ryan Kawano
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
	public Collider2D yeah;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.CompareTag("Player")) //If collision was with Greg
    	{
	    	Destroy(gameObject); //Destroy object
    	}

    }
}
