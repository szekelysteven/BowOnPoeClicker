using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public bool isFullScreen = true;
    public AudioMixer audioMixer;

    public void SetVolume(float sliderValue)
    {
        audioMixer.SetFloat("totalVolume", Mathf.Log10 (sliderValue)*20); //converts our slider value to a logarithmic scale
    }

    public void muteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void setFullscreen()
    {
        if( isFullScreen == false)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            isFullScreen = true;
            Debug.Log("the game is now fullscreen");
        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
            isFullScreen = false;
            Debug.Log("the game is now windowed");
        }
    }
}
