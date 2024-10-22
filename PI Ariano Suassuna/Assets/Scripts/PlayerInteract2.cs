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
        if (other.CompareTag("Interactable"))
        {
            isnearObj = true;
            Interact();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            isnearObj = false;
        }
    }

    void Interact()
    {
        if(CompareTag("Bau 2") && Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 0;
            SuassunasWorks.Invoke();
        }
    }




}
