using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemySpawn;  // Array com os Prefabs 
    public Transform[] spawnPoints;  // Array com os possíveis pontos de spawn
    public float enemyRate = 3f;  // Raio para spawnar randômicamente ao redor do inimigo
    private EnemyManeger enemyManager;
    //public TMPro scoreTxt;
    public GameObject Score;
    public int life = 3;
    public int damege = 1;
    public float speed;
    Rigidbody2D body;
    int direction = 1;

    


    void RandomSpawn()
    {
        // Escolhe o prefab no qual esta no array
        GameObject objetoParaSpawnar = enemySpawn[Random.Range(0, enemySpawn.Length)];


        Vector3 posicaoSpawn;
        if (spawnPoints.Length > 0)
        {
            Transform pontoSpawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            posicaoSpawn = pontoSpawn.position;
        }
        else
        {
            // Gera uma posição aleatória 
            Vector2 posicaoAleatoria = Random.insideUnitCircle * enemyRate;
            posicaoSpawn = new Vector3(transform.position.x + posicaoAleatoria.x, transform.position.y + posicaoAleatoria.y, 0);
        }

        // Instancia o objeto na posição de spawn
        Instantiate(objetoParaSpawnar, posicaoSpawn, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        enemyManager = FindObjectOfType<EnemyManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(speed * direction, body.velocity.y);    
        if (life <= 0)
        {
            Die();
        }
        //scoreTxt.text = score.ToString();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {            
            life -= collision.gameObject.GetComponent<Bullet>().damege;
            Debug.Log("Tomei");
            Die();

        }
        if (collision.CompareTag("Void"))
        {
            Die();
        }
        
    }
    private void OnDestroy()
    {
        if (enemyManager != null)
        {
            enemyManager.EnemyDestroyed();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
