using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
   [SerializeField] GameObject finder;
    
   void Update()
       {
    if (GetComponent<GameTimer>().GetProzent() >= 0.5f)
    {
            
            finder.SetActive(true);
    }
         
   }
}
