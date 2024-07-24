using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool grondCheck;
    public Transform foot;
    float speed = 5, jumpStreigth = 5;
    public Rigidbody2D body;
    Collider2D footCollision;
    int direction = 1;
    float horizontal;
    public int life = 3;
    public GameObject damege;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grondCheck = Physics2D.OverlapCircle(foot.position, 0.05f);
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        if (Input.GetButtonDown("Jump") && grondCheck)
        {
            body.AddForce(new Vector2(0, jumpStreigth * 100));

        }
        if (horizontal != 0)
        {
            direction = (int)horizontal;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Thorn"))
        {
         life -= collision.gameObject.GetComponent<Thorns>().damage;
            
            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }
       
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       /* if (collision.CompareTag("Thorns"))
        {
            life -= collision.gameObject.GetComponent<Thorns>().damege;

            Destroy(collision.gameObject);

            if (life <= 0)
            {

                Destroy(gameObject);

            }
        }*/
    }
}

