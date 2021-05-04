using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteVolume : MonoBehaviour
{
    private bool isMuted;
    // Start is called before the first frame update
    void Start()
    {
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;

    }

    // Update is called once per frame
    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        // the playerprefs is going to ask the program if its true or false
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
    }
}
