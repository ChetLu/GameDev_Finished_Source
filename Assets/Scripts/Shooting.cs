using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;         //fixed point on player that missile will spawn from
    public GameObject missilePrefab;    //reference to missile object 

    // Update is called once per frame
    void Update()
    {
        //spawns new missile when fire button is pressed
        if (Input.GetButtonDown("Fire1") && !PauseMenu.gameIsPaused)//this button will be the left mouse
        {
            fire();
        }
    }

    void fire()
    {
        Debug.Log("missile fired");
        FindObjectOfType<AudioManager>().Play("ShootingSound");
        Instantiate(missilePrefab, firePoint.position, firePoint.rotation);
    }
}
