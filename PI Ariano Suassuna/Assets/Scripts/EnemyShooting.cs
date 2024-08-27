using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject projetilEnemyPrefab;
    public Transform firePoint;
    public float fireRate = 5f;

    private float nextFireTime = 0f;
    private bool facingRight = true;
       
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time +1f / fireRate;
        }
    }
    void Shoot()
    {
        GameObject projectile = Instantiate(projetilEnemyPrefab, firePoint.position, firePoint.rotation);
        if (!facingRight)
        {
            Vector3 theScale = projectile.transform.localScale;
            theScale.x = -1;
            projectile.transform.localScale = theScale;
        }
    }
    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
