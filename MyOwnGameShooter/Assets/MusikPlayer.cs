using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikPlayer : MonoBehaviour
{
    OptionSaver options;
    
    void Start(){
        Sinelton();
        options = FindObjectOfType<OptionSaver>();
        

    }

    void Update()
        {
        if (options)
        {
           // Debug.Log("Found Ya");
            Debug.Log(options.GetVolume());

            GetComponent<AudioSource>().volume = options.GetVolume();

        }
      //  else Debug.Log("DAMNNNNN");
    }
    private void Sinelton()
    {
        int noumberOfMusik = FindObjectsOfType<MusikPlayer>().Length;
        if (noumberOfMusik > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);//Debug.Log("I died so you can live on!!");
        }
        else
        {
            DontDestroyOnLoad(gameObject);// Debug.Log("DONTDESTROYONLOAD"); 
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
