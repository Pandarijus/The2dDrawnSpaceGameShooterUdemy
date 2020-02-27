using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Projectile")]
    [SerializeField] float shotDelay = 2f;
    [SerializeField] bool isShoot = true;
    [SerializeField] GameObject projectile;
    [SerializeField] float shotSpeed;
    [SerializeField] float destroyShotSec = 2f;
    [SerializeField] bool isSawGuy = false;
    [SerializeField] float sawGuyShotAngle = 5f;
    DeathBomb deathBomb;
    Player player;
    float randomAngle;
    
    
   

    void Start()
    {

       
        StartCoroutine(Shoot());
        
        player = FindObjectOfType<Player>();
    }
    
    IEnumerator Shoot()
    {

        while (isShoot)
        {

            yield return new WaitForSeconds(shotDelay);
            HandleShot();

        }
    }
    private void HandleShot()
    {
        GameObject a = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        if (isSawGuy)
        {
            randomAngle = Random.Range(-sawGuyShotAngle,sawGuyShotAngle);
            a.GetComponent<Rigidbody2D>().velocity = new Vector2(randomAngle, -shotSpeed);
        }
        else
        {
            a.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -shotSpeed);
        }

       



        Destroy(a, destroyShotSec);

    }

    





 
   


}
