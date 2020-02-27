using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorpChance : MonoBehaviour
{
   // [SerializeField] Pickups pickup;
    [SerializeField] GameObject pickup;
    [SerializeField] bool droping = true;
    [SerializeField] float spawnTime = 2f;
    [SerializeField] float randomRangeY = 10f;
    [Header("Selection!")]
    [SerializeField] bool thisIsDropSpawner = false;
    float x, y;
    int i,d;
    [SerializeField] int howManyRepeats = 0;
    [SerializeField] bool isRockets = false;
    void Start(){

       // SpawnPickup();
        if (thisIsDropSpawner)
        {
            StartCoroutine(SpawnRandom());
        }
        
    }

    public void SpawnPickup()
    {
        
        if (( FindObjectOfType<counter>().GetD()%2)==0)
        {
           Debug.Log(FindObjectOfType<counter>().GetD());
            Instantiate(pickup, transform.position, Quaternion.identity);
        }
        FindObjectOfType<counter>().AddD();
    }

   IEnumerator SpawnRandom()
    {
        while (droping)
        {
           x= Random.Range(-2.5f,2.5f);
           y= Random.Range(0, randomRangeY);
            yield return new WaitForSeconds(spawnTime);

            if (isRockets)
            {

                GameObject a = Instantiate(pickup, new Vector2(transform.position.x + x, transform.position.y + y), Quaternion.Euler(0, 0, 180))as GameObject;
                Destroy(a,3f);
            }
            else
            {
                
                Instantiate(pickup, new Vector2(transform.position.x + x, transform.position.y + y), Quaternion.identity);
            }

           
            i++;
           
            if (i == howManyRepeats)
            {
                droping = false;
            }
        }
    }
     
    
}
