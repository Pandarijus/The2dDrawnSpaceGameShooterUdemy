using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioClip AudioSourceYouWantToPlay;
     float volume;
    [SerializeField] float volumePlus = 0.2f;
    

    public void Play()
    {
       
        volume = FindObjectOfType<OptionSaver>().GetVolume()+volumePlus;
        if (volume>1)
        {
            volume = 1f;
        }
        Debug.Log("I USE AUDIO   " + volume );
        AudioSource.PlayClipAtPoint(AudioSourceYouWantToPlay, Camera.main.transform.position, volume);
    }

  

}
