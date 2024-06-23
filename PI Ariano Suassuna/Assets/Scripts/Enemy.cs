using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life = 3;
    public int damege;
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {//Aqui o collision representa o Bullet
            life -= collision.gameObject.GetComponent<Bullet>().damege;

            Destroy(collision.gameObject);//Esse destroi o tiro (bullet)

        }

    }
}