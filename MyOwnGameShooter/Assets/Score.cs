using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] int myScore= 100;

    public void AddScore(int add)
    {
        myScore += add;
    }

    void Update()
        {
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();     
    }

    
}
