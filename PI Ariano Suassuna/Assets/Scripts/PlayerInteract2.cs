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
            Interact(other);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            isnearObj = false;
        }
    }

    void Interact(Collider2D other)
    {
        if(CompareTag("Bau 2") && Input.GetKeyDown(KeyCode.F))
        {
            SuassunasWorks.Invoke();
        }
    }




}
