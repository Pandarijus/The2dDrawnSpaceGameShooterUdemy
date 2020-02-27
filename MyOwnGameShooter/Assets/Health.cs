using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    
    [SerializeField] int health =100;
    [SerializeField] int scorePerDeath= 50;
    [Header("Selection!")]
    [SerializeField] bool invinceble = false;
    [SerializeField] bool thisIsEnemy = false;
    [SerializeField] bool isSpawnDrop = false;
    [Header("After Death")]
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject dude;
    [SerializeField] float waitForSecounds = 1f;
    [SerializeField] int levelNumber;
    

    


    public int GetHealth()
    {
        return health;
    }
    public void AddHealth(int add)
    {
        health += add;
    }
    public void MinusHealth(int damage)
    {
        health -= damage;
        if (health <= 0 && invinceble==false)
        {
           
            if (thisIsEnemy)
            {
                FindObjectOfType<Score>().AddScore(scorePerDeath);
               if (dude)
               {
                    
                    SpawnDude();
                }
              
                
                if (GetComponent<DorpChance>()&&isSpawnDrop)
                {
                    GetComponent<DorpChance>().SpawnPickup();
                }
                
                DeathExplosion();
                Destroy(gameObject);
            }
            else
            {
               StartCoroutine(     Waite());

               
            }
           
            
           Destroy(gameObject);
        }
    }
    private IEnumerator Waite()
    {
       

        GetComponent<Audio>().Play();
        switch (levelNumber)
        {
            case 1: FindObjectOfType<Manager>().LoadDeath();
                break;
            case 2:
                FindObjectOfType<Manager>().LoadDeath2();
                break;
            case 3:
                FindObjectOfType<Manager>().LoadDeath3();
                break;
            default: Debug.Log("Deathscreen not here");
                break;
        }
        
        yield return new WaitForSeconds(waitForSecounds);
        


       

    }
    private void OnTriggerEnter2D(Collider2D collision)
           {
        if (collision.GetComponent<Damage>()&&health>0)
        {
            MinusHealth(collision.GetComponent<Damage>().GetDamage());
        }
        

           }
    public void DeathExplosion()
    {
        GameObject a = Instantiate(  explosion , transform.position  ,Quaternion.identity) as GameObject;
        Destroy(a,3f);
         //(Welches Object, Welche Position, Rotation 
    }

    public void SpawnDude()
    {


        Instantiate(dude, transform.position, Quaternion.identity);


    }

}
