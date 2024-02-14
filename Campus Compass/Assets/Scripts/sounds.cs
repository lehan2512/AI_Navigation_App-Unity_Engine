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

    
    
    public void playSoundOnClick()
    {
        source.Play();
    }

    // not  to change

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);      
        }
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
