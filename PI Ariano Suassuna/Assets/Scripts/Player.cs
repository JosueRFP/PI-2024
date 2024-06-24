using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool grondCheck;
    public Transform foot;
    float speed = 5, jumpStreigth = 5, bulletSpeed = 8;
    public GameObject bullet;
    public GameObject damege;
    public Rigidbody2D body;
    Collider2D footCollision;
    int direction = 1;
    float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grondCheck = Physics2D.OverlapCircle(foot.position, 0.05f);
        horizontal = Input.GetAxisRaw("Horizontal");
        //GetAxixRaw para jogos antigos que vão na velocidade maxima
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        if (Input.GetButtonDown("Jump") && grondCheck)
        {
            body.AddForce(new Vector2(0, jumpStreigth * 100));

        }
        if (horizontal != 0)
        {
            direction = (int)horizontal;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject temp = Instantiate(bullet, transform.position, transform.rotation);
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction, 0);
        }
    }
}
