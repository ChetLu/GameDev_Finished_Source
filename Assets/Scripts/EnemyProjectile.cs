using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    private GameObject playerObj = null;
    public float projectileSpeed;
    public Rigidbody2D rb;
    private bool invincibileState;
    private int playerHealth;
    public Vector3 a;

    // Start is called before the first frame update
    void Start()
    {
        a = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //assigns Player to the playerObj
        if (playerObj == null)
        {
            playerObj = GameObject.FindWithTag("Player");
        }

        //sets the velocity of the projectile
        rb.velocity = transform.up * projectileSpeed;
    }

    void Update()
    {
        TooFar();
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("missile is hitting " + hitInfo.name);
        //sets bool to the invicibilty state of the player
        invincibileState = playerObj.GetComponent<Player>().invincibility;
        playerHealth = FindObjectOfType<Player>().health;
        Asteroid a = hitInfo.GetComponent<Asteroid>();

        if (hitInfo.gameObject.tag == "Player")
        {
            //if invincibility is on, missiles pass through player
            if (invincibileState)
            { 
                return;
            }
            else
            {
                
                //invicibility off, reduce player health by one
                if (playerHealth >= 1)
                {
                    FindObjectOfType<AudioManager>().Play("HitSound");
                    Destroy(gameObject);
                    Debug.Log("player hit");
                    playerHealth --;
                    Debug.Log(playerHealth);
                    FindObjectOfType<Player>().health = playerHealth;
                }
                
                if (a != null)
                {
                    
                }
            }

            Destroy(gameObject);

        }

        Debug.Log(hitInfo.name);
        //remove missile from scene upon collision
        
    }

    void TooFar()
    {
        if (Mathf.Abs(transform.position.y - a.y) >= 10)
        {
            Destroy(gameObject);
        }
    }
}
