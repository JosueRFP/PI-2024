using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    public TextMeshPro scoreTxt;
    public int score;
    public int damege = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = score.ToString("Score");
    }
    private void OnBecameInvisible()
    {
        
    }
    private void OnBecameVisible()
    {
        Destroy(gameObject, 0.25f);
    }
       
   private void OnTriggerEnter2D(Collider2D col)
   {
        if (col.CompareTag("Enemy") == true)
        {
            score = score + 1;
        }
    }
    
}