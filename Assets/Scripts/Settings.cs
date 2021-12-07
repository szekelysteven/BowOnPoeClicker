using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public bool isFullScreen = true;
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
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
