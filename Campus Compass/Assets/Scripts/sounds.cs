using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sounds : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);      
        }
    }
}
