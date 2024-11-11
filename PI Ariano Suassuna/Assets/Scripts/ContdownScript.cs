using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ContdownScript : MonoBehaviour
{
    
    public float timeRemaining = 300f;  // Tempo inicial em segundos
    public TextMeshProUGUI countdownText;  // ReferÍncia ao TextMeshPro

    private bool timerIsRunning = false;

    void Start()
    {
        timerIsRunning = true;
        UpdateTimerText();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerText();
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                UpdateTimerText();
                OnTimerEnd();                
            }
        }
    }

    void UpdateTimerText()
    {
        countdownText.text = Mathf.CeilToInt(timeRemaining).ToString();
    }

    void OnTimerEnd()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
}
