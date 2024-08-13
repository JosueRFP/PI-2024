using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField]float remainigTime;
    //public TMPro.TextMeshPro m_TextMeshPro;
    //public float maxValue = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainigTime -= Time.deltaTime;
        timerText.text = remainigTime.ToString();
        int menutes = Mathf.FloorToInt(remainigTime / 60);
        int seconds = Mathf.FloorToInt(remainigTime % 60);
        timerText.text = string.Format("{00;00}: {01:00}", menutes, seconds);
        //temp = temp + Time.deltaTime;
        //Debug.Log(temp);
        /*
        float timer = Time.deltaTime;
        if( timer < 1 ) 
        {
            maxValue--;

        }*/

    }
}
