using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damege = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnBecameInvisible()
    {
        
    }
    private void OnBecameVisible()
    {
        Destroy(gameObject, 0.25f);
    }
}