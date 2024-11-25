using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class ContdownScript : MonoBehaviour
{
    public GameObject endGameBad;
    public static float timeRemaining = 421f;  // Tempo inicial em segundos
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
        timeRemaining += 421;
        Time.timeScale = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
}
