using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] int addHealth = 115;
    
     private void OnTriggerEnter2D(Collider2D collision)
           {
       
        if (collision.GetComponent<Health>())
        {
            collision.GetComponent<Health>().AddHealth(addHealth);


            Destroy(gameObject);
        }
            
           }
}
