using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractHistory : MonoBehaviour
{
    public UnityEvent SuassunasHistory;
    private bool isNearObj = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            isNearObj = true;
            SuassunasHistory.Invoke();

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            isNearObj = false;
        }
    }

    void Update()
    {
        if (CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            SuassunasHistory.Invoke();
            Debug.Log("Senta que la vem história");
            Time.timeScale = 0;
        }

        /*else if(!isNearObj && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Não Interagiu!");
            SuassunasHistory.Invoke();
            Time.timeScale = 1;

        }*/
    }
}
