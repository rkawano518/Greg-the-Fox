using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
	public GameObject pausedMenu;
	public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pausedMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        	if(isPaused)
        	{
        		ResumeGame();
        	}
        	else
        	{
        		PausedGame();
        	}
        }
    }

    public void PausedGame()
    {
    	pausedMenu.SetActive(true);
    	Time.timeScale = 0f;
    	isPaused = true;
    }

    public void ResumeGame()
    {
    	pausedMenu.SetActive(false);
    	Time.timeScale = 1f;
    	isPaused = false;
    }

       public void GoToMainMenu()
    {
    	Time.timeScale = 1f;
    	SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
    	Application.Quit();
    }
}
