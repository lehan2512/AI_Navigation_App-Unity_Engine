using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffectsonclick : MonoBehaviour
{
    public AudioSource src;
    public AudioClip soundClick;
    public void playClickSound()
    {
        src.clip = soundClick; 
        src.Play();
    }
}
