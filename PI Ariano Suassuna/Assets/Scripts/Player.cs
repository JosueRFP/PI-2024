using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{   
    public Transform foot;
    public GameObject bulletPrefab;
    public GameObject damege;
    public Rigidbody2D body;
    public int life;
    public GameObject m_void;
    public Transform bulletSpawn;
    public SpriteRenderer spriteRenderer;
    public UnityEvent OnPause, OnUnPause, SpikedPlayer;
    public Animator animator;

    private float horizontalInput;
    bool grondCheck;
    float move;
    int direction = 1;
    Collider2D footCollision;
    float speed = 3f, jumpStreigth = 35f, bulletSpeed = 4;
    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
        grondCheck = Physics2D.OverlapCircle(foot.position, 0.05f);
        move = Input.GetAxisRaw("Horizontal");
        //GetAxixRaw para jogos antigos que vão na velocidade maxima
        body.velocity = new Vector2(move * speed, body.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
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
            theScale.x *= -1;
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

    private void FixedUpdate()
    {
        if(move <= -1.0f)
        {
            //spriteRenderer.flipX = false;
        }
        if(move >= 1.0f)
        {
            //spriteRenderer.flipX = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Void"))
        {
            Destroy(gameObject);
            SpikedPlayer.Invoke();
        }
        

    }
}
