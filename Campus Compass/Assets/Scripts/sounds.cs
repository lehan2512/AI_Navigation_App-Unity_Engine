using System.Collections;
using System.Collections.Generic;
using System.Media;
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
    
    public void playSoundOnClick()
    {
        source.Play();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);      
        }
    }
}
