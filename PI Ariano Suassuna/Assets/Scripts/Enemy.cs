using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life = 3;
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
        if (collision.CompareTag("Player"))
        {
            //quando o inimigo colide com o Player, o inimigo destroi -> ver script Player
            //life -= collision.gameObject.GetComponent<Player>();

            Destroy(collision.gameObject);

            if (life <= 0)
            {

                Destroy(gameObject);
            }
        }

    }
}