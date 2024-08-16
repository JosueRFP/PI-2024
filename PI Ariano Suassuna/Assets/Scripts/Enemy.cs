using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int life = 3;
    public int damege = 1;
    public float speed;
    Rigidbody2D body;
    int direction = 1;
    public int Respawn;

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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            life -= collision.gameObject.GetComponent<Bullet>().damege;

            Destroy(collision.gameObject);

           
        }
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(Respawn);
        }
    }
}