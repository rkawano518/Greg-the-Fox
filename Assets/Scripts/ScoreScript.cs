//Ryan Kawano
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
	public Text MyscoreText;
	private int ScoreNumber;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber = 0;
        MyscoreText.text = Convert.ToString(ScoreNumber);
    
}
    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.tag == "Gem")
    	{
    		ScoreNumber++;
    		Destroy(collision.gameObject);
    		MyscoreText.text = Convert.ToString(ScoreNumber);
    	}
    }
}
