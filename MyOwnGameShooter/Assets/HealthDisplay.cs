using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    Player player;
    void Start(){
    player = FindObjectOfType<Player>();
    
    }

    

    void Update()
    {
        if (player)
        {
            GetComponent<TextMeshProUGUI>().text = player.GetComponent<Health>().GetHealth().ToString();
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "0";
        }
       
    }

}
