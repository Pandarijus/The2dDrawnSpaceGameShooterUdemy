using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{



    Player player;
    [SerializeField] float moveSpeed = 2f;
    float movementPerFrame;
    [SerializeField] bool isChase = true;

    void Start(){
        
        player = FindObjectOfType<Player>();
        Chase();
       
    }



    void Update()
        {
        if (player)
        {
            Chase();
        }
       
    }
   
    
    public void Chase()
    {
        
        movementPerFrame = moveSpeed * Time.deltaTime;



        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, movementPerFrame);

    }
         
        

        
         
        
      
        
                   
         }
