using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virarojogador : MonoBehaviour
{
    //
    // Start is called before the first frame update
    //void Start()
    // {

    //}

    // Update is called once per frame
    //void Update()
    // {

    // }
    private Rigidbody2D corpo;
    private SpriteRenderer sprite;
    public float velocidade = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        corpo = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //Debug.Log(horizontal);

        Flip(horizontal);
        corpo.velocity = new Vector2(horizontal * velocidade, corpo.velocity.y);

    }
    private void Flip(float horizontal)
    {
        if (horizontal >= 0)
        {
            sprite.flipX = false;
        }
        else if (horizontal < 0)
        {
            sprite.flipX = true;
        }
    }
}

