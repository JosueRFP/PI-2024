using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;
    public TextMeshPro scoreTxt;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreTxt.text = score.ToString("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy") == true)
        {
            score = score+1;
        }
    }
    // Video referencia: https://www.youtube.com/watch?v=i1XQL_MYWCY
}
