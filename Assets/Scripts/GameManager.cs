using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject menuUI;
    
    public Text scoreText;
    

    public Player playerObj;
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        
        //playerObj = GameObject.FindWithTag("Player");
        menuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {       
        scoreText.text = "Score: " + playerObj.score.ToString();
        if (timer.remainingTime <= 0)
        {
            EndGame();
        }
        if (!playerObj.alive)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        if (!gameOver)
        {
            gameOver = true;
            menuUI.SetActive(true);
            //Time.timeScale = 0f;
        }
    }
    public void Restart()
    {
        gameOver = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
