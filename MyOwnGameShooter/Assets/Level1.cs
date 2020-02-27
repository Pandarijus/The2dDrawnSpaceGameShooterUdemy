using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    [SerializeField] float time = 2f;
    [SerializeField] GameObject budy;
    bool loop = true;
    int i;
    void Start(){
    
     StartCoroutine(     Level());
    }

    IEnumerator Level()
    {
        while (loop)
        {
            i++;
            yield return new WaitForSeconds(time);
            Instantiate(budy, transform.position, Quaternion.identity);
            //(Welches Object, Welche Position, Rotation 
            if (i==30)
            {
                loop = false;
            }
        }

    }
}
