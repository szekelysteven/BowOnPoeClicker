using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

//this code was written using the following brackey's tutorial
//https://www.youtube.com/watch?v=YOaYQrN1oYQ

public class Settings : MonoBehaviour
{
    Resolution[] resolutions;

    public bool isFullScreen = true;
    public AudioMixer audioMixer;
    public TMP_Dropdown resolutionDropdown;

    public void SetVolume(float sliderValue)
    {
        audioMixer.SetFloat("totalVolume", Mathf.Log10 (sliderValue)*20); //converts our slider value to a logarithmic scale
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

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    private void Start()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen; // put the game in full screen

        resolutions = Screen.resolutions; //get all the resolutions the device can handle

        resolutionDropdown.ClearOptions(); //get rid of any options set up in the unity client

        List<string> options = new List<string>(); //format these as a list of strings

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++) 
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option); // add each resolution string to our options dropdown list

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i; //set i to your native resolution by default
            }
        }       
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
}
