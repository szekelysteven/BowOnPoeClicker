using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour
{
    public GameObject gameCanvas;
    public GameObject menuCanvas;
    public GameObject settingsCanvas;

    private void Start()
    {
        gameCanvas.SetActive(true);
    }

    public void Pause()
    {        
        gameCanvas.SetActive(false);
        menuCanvas.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("paused");
    }

    public void Play()
    {
        menuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
        Time.timeScale = 1;
        Debug.Log("resumed");
    }

    public void enterSettings()
    {
        menuCanvas.SetActive(false);
        settingsCanvas.SetActive(true);
    }

    public void leaveSettings()
    {
        settingsCanvas.SetActive(false);
        menuCanvas.SetActive(true);
    }


}
