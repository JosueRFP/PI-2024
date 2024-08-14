using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeLevel_txt;
    private float timeLevel;
    public static bool stopTime;
    
    void Start()
    {
        stopTime = false;
    }

    
    void Update()
    {
        if (stopTime == false)
        {
            timeLevel = timeLevel - Time.deltaTime; 
            timeLevel_txt.text = timeLevel.ToString("F0");
        }

    }
}
