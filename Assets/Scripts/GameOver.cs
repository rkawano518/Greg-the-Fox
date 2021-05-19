using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	//public Text pointText;

  /*  public void Setup(int score)
    {
    	gameObject.SetActive(true);
    	pointsText.text = score.ToString() + " POINTS";
    }
*/
    public void RestartButton()
    {
    	SceneManager.LoadScene("Level 3");
    }

    public void ExitButton()
    {
    	SceneManager.LoadScene("Test Menu");
    }

}
