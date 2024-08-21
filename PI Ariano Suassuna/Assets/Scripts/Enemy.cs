using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    //public TMPro scoreTxt;
    public GameObject Score;
    public int life = 3;
    public int damege = 1;
    public float speed;
    Rigidbody2D body;
    int direction = 1;
   

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(speed * direction, body.velocity.y);    
        if (life <= 0)
        {
            Destroy(gameObject);
        }
        //scoreTxt.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
            life -= col.gameObject.GetComponent<Bullet>().damege;
            Destroy(col.gameObject);
        }
        
    }
}