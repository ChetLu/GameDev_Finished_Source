using UnityEngine;
using UnityEngine.UI;
public class PlayerInfo : MonoBehaviour
{
    private GameObject playerObj = null;
    public Text scoreText;
    public Text healthText;

    void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.FindWithTag("Player");
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Updates the Score text with the total points after more enemies have been killed
        scoreText.text = "Score: " + playerObj.GetComponent<Player>().score.ToString();
        healthText.text = "Health: " + playerObj.GetComponent<Player>().health.ToString();
    }
}