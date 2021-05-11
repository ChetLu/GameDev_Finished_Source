using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject menuUI;
    public GameObject camera;
    public bool audioEnabled;
    void Start()
    {
        menuUI.SetActive(false);
        audioEnabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.GetComponent<AudioListener>().enabled=audioEnabled;
        if (Input.GetKeyDown(KeyCode.P)) { 
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }       
    }

    public void Resume()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    
    void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);       
    }

    //toggle function for Toggle in the UI 
    public void Audio_Toggle(bool newValue)
    {
        //on each click bool will be flipped to opposite value
        audioEnabled = !audioEnabled;
    }
}
