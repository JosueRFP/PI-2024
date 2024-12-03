using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class ContdownScript : MonoBehaviour
{

    void LoadHighScoreLevel()
    {
        // Load the level named "HighScore".
        SceneManager.LoadScene("Fase1");

    }
    public GameObject endGameBad;
    public static float timeRemaining = 301f;  // Tempo inicial em segundos
    TimeSpan timerSpan = TimeSpan.FromSeconds(timeRemaining);
    public TextMeshProUGUI countdownText;  // Referência ao TextMeshPro

    private bool timerIsRunning = false;

    void Start()
    {
        timerIsRunning = true;
        //UpdateTimerText();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timerSpan = TimeSpan.FromSeconds(timeRemaining);
                //UpdateTimerText();
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                //UpdateTimerText();
                OnTimerEnd();                
            }
            countdownText.text = timerSpan.ToString(@"mm\:ss");
        }
    }

    /*void UpdateTimerText()
    {
        countdownText.text = Mathf.CeilToInt(timeRemaining).ToString(@"mm\:ss");
    }*/

    void OnTimerEnd()
    {
        endGameBad.SetActive(true);
        Time.timeScale = 0;
        timeRemaining += 301;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
}