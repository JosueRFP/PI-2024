using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;

public class Player : MonoBehaviour
{
    public UnityEvent OnPause;
    public UnityEvent OnUnPause;
    public UnityEvent SpikedPlayer;

   
    bool grondCheck;
    public Transform foot;
    float speed = 5, jumpStreigth = 25, bulletSpeed = 8;
    public GameObject bulletPrefab;
    public GameObject damege;
    public Rigidbody2D body;
    Collider2D footCollision;
    int direction = 1;
    float move;
    public int life;
    public GameObject Void;
    public GameObject painelDied;
    public Transform bulletSpawn;
    private bool facingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        grondCheck = Physics2D.OverlapCircle(foot.position, 0.05f);
        move = Input.GetAxisRaw("Horizontal");
        //GetAxixRaw para jogos antigos que vão na velocidade maxima
        body.velocity = new Vector2(move * speed, body.velocity.y);
        if(move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }
        if (Input.GetButtonDown("Jump") && grondCheck)
        {
            body.AddForce(new Vector2(0, jumpStreigth * 100));

        }
        if (move != 0)
        {
            direction = (int)move;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                OnUnPause.Invoke();
            }
            else
            {
                Time.timeScale = 0;
                OnPause.Invoke();
            }
        }

        void Flip()
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;
        }

        void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (facingRight)
            {
                rb.velocity = new Vector2(10, 0); //Direita
            }
            if (!facingRight)
            {
                rb.velocity = new Vector2(-10, 0); //Esquerda
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life -= collision.gameObject.GetComponent<Enemy>().damege;

            if (life <= 0)
            {
                Destroy(gameObject);
                Instantiate(painelDied, transform.position, transform.rotation);
                SpikedPlayer.Invoke();
            }

        }
        if (collision.gameObject.CompareTag("Void"))
        {
            Destroy(gameObject);
            Instantiate(painelDied, transform.position, transform.rotation);
            SpikedPlayer.Invoke();
        }
        
        
    }
   
}
