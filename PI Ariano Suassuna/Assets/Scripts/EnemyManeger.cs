using UnityEngine;
using TMPro;

public class EnemyManeger : MonoBehaviour
{
    public GameObject endGameGood;
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
        enemyCounter.text = "Cactos Restantes " + totalEnemies;
        enemyCounter.color = Color.red;
        if (totalEnemies == 0)
        {
            endGameGood.SetActive(true);    
            Time.timeScale = 0f;
        }
       
    }
}
