using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Movement movement;

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MusicOnOff()
    {
        int music = PlayerPrefs.GetInt("music");
        PlayerPrefs.SetInt("music", music == 1 ? 0 : 1);
        Debug.Log(PlayerPrefs.GetInt("music"));
    }

    public void SoundOnOff()
    {
        int sound = PlayerPrefs.GetInt("sound");
        PlayerPrefs.SetInt("sound", sound == 1 ? 0 : 1);
        Debug.Log(PlayerPrefs.GetInt("sound"));
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
