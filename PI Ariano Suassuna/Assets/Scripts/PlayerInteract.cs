using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract : MonoBehaviour
{
    public UnityEvent SuassunasHistory;
    private bool isNearObj = false;

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
        if(isNearObj && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interagiu");
            SuassunasHistory.Invoke();
        }
    }
}
