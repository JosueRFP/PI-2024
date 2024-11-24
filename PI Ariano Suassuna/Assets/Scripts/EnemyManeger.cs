using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyManeger : MonoBehaviour
{
    public GameObject endGame;
    public TextMeshProUGUI enemyCounter;
    private int totalEnemies;


    // Start is called before the first frame update
    void Start()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        UpdateEnemyCount();
    }
    public void EnemyDestroyed()
    {
        totalEnemies--;
        UpdateEnemyCount();
    }

    void UpdateEnemyCount()
    {
        enemyCounter.text = "Enemies Left " + totalEnemies;
        enemyCounter.color = Color.red;
        if (totalEnemies == 0)
        {
            endGame.SetActive(true);
        }
    }
}
