using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionSaver : MonoBehaviour
{
    
    void Start(){

        DontDestroyOnLoad(gameObject);
    }
     
    float volume;

    public float GetVolume()
    {
        return volume;
    }
    public void SetVolume(float a)
    {
        volume = a;
    }

}
