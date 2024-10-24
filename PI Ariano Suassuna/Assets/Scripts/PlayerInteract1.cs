using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract1 : MonoBehaviour
{
    public UnityEvent SuassunasHistory;
    private bool isNearObj = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
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
        if(CompareTag("Bau 1") && Input.GetKeyDown(KeyCode.E))
        {
          SuassunasHistory.Invoke();
          Debug.Log("Senta que la vem história");
        }

        /*else if(!isNearObj && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Não Interagiu!");
            SuassunasHistory.Invoke();
            Time.timeScale = 1;

        }*/
    }
}
