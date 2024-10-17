using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract2 : MonoBehaviour
{
    bool isnearObj = true;
    public UnityEvent SuassunasWorks;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isnearObj = true;
            Interact();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isnearObj = false;
        }
    }

    void Interact()
    {
        if(CompareTag("Bau") && Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 0;
            SuassunasWorks.Invoke();
        }
    }




}
