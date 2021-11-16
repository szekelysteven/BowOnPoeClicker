using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDestroy : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if (this.tag == "Audio1")
        {
            audioSource.Play();
        }
    }
}
