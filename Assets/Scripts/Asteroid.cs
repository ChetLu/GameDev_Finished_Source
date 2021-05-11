using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public void GetHit()
    {
        FindObjectOfType<AudioManager>().Play("HitSound");
        Destroy(gameObject);
    }

}
