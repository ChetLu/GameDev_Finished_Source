using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;
    public float score;
    public bool invincibility;
    public int health =3;
    public bool alive;

    public GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");
        transform.position += new Vector3(movementX, movementY, 0) * Time.deltaTime * movementSpeed;

        if (health == 0)
        {
            alive = false;
        }

        Die();
    }
   
    //toggle function for Toggle in the UI 
    public void Toggle_Changed(bool newValue)
    {
        //on each click bool will be flipped to opposite value
        invincibility = !invincibility;
    }

    public void Die()
    {
        if (!alive)
        {            
            Destroy(gameObject);
        }
    }
}
