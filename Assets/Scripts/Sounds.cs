using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sounds
{

    public AudioClip clip;
    public string name;

    [HideInInspector]
    public AudioSource source;
}
