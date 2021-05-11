using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sounds[] sounds;

    void Awake()
    {
        foreach (Sounds s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play (string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
