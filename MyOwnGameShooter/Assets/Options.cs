using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField] GameObject difficulty;
    [SerializeField] GameObject volume1;
    [SerializeField] GameObject health;
    [SerializeField] GameObject droprate;
  //  TESTMUSK musk;
    OptionSaver saver;
    void Awake(){
    //musk = FindObjectOfType<TESTMUSK>();
        saver = FindObjectOfType<OptionSaver>();
        saver.SetVolume(GetVolume());
       
        // DontDestroyOnLoad(gameObject);

    }

    void Update()
        {
        if (saver)
        {
            // musk.SetVolume(GetVolume());
            saver.SetVolume(GetVolume());
            Debug.Log(GetVolume());
        }
       
    }

       
    

    public float GetVolume()
    {
      return  volume1.GetComponent<Slider>().value;//funkt 0--1
    }


    
}
