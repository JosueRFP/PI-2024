using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract1 : MonoBehaviour
{
    public static UnityEvent SuassunasHistory;
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
            Time.timeScale = 0;
            
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
        if(CompareTag("Bau") && Input.GetKeyDown(KeyCode.E))
        {
          SuassunasHistory.Invoke();
          Time.timeScale = 0;
          Debug.Log("Senta que la vem hist�ria");
        }

        /*else if(!isNearObj && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("N�o Interagiu!");
            SuassunasHistory.Invoke();
            Time.timeScale = 1;

        }*/
    }
}