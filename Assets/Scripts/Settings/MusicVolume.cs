using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    public AudioSource AudioSource;
    private float musicvolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();

    }

    void Update()
    {
        AudioSource.volume = musicvolume;
    }

    public void updatevolume(float volume)
    {
        musicvolume = volume;
    }
}
