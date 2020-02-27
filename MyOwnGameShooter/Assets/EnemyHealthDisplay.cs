using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealthDisplay : MonoBehaviour
{
    Enemy enemy;
    void Start()
    {
        enemy = FindObjectOfType<Enemy>();

    }



    void Update()
    {
        if (enemy.GetComponent<Health>())
        {
            GetComponent<TextMeshProUGUI>().text = enemy.GetComponent<Health>().GetHealth().ToString();
        }
        
    }

}
