using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundRules : MonoBehaviour
{
    public string round = "333";
    public static int startAmount;

    // Start is called before the first frame update
    void Start()
    {
        calcStartAmount();
        Debug.Log("TEST: " + startAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calcStartAmount()
    {
        
        for(int i = 0; i < round.Length; i++)
        {
            char c = round[i];
            startAmount += (c - '0');
        }
    }
}
