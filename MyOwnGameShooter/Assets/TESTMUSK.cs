using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTMUSK : MonoBehaviour
{
   public void SetVolume(float a)
    {
        GetComponent<AudioSource>().volume = a;
    }
}
