using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{
    [SerializeField] float levelTime = 30f;
    bool gameTime = true;
   [SerializeField] float waitForSecounds = 2f;
    
   // [SerializeField] AudioClip AudioSorceYouWantToPlay;
   // [SerializeField] float volume = 2f;
    void Start(){
    
    
    }

    void Update()
        {
        GetComponent<Slider>().value =  Time.timeSinceLevelLoad/levelTime ;    
        if (Time.timeSinceLevelLoad>= levelTime && gameTime)
        {
            gameTime = false;
            
            
             StartCoroutine( Wait());
            //stop spawning and win screen
        }
    }

    
    IEnumerator Wait()
    {
        // AudioSource.PlayClipAtPoint(AudioSorceYouWantToPlay, Camera.main.transform.position, volume);
        FindObjectOfType<MusikPlayer>().Destroy();
        GetComponent<Audio>().Play();
        yield return new WaitForSeconds(waitForSecounds);
      
        FindObjectOfType<Manager>().LoadWinGame();
        
    }
    public float GetProzent()
    {
        return Time.timeSinceLevelLoad / levelTime;
    }
    
}
