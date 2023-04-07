using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioSource runningSound;
    public AudioSource jumpingSound;
    // public AudioSource sampleMusic;

    void Start()
    {
        int sound = PlayerPrefs.GetInt("sound");
        PlayerPrefs.SetInt("sound", sound == 1 ? 0 : 1);
        Debug.Log(PlayerPrefs.GetInt("sound"));
        if (sound == 1)
        {
            runningSound.enabled = true;
            jumpingSound.enabled = true;
        }
        else
        {
            runningSound.enabled = false;
            jumpingSound.enabled = false;
        }

    }

    void Update()
    {

    }
}
