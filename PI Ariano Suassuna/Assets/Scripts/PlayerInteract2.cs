using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract2 : MonoBehaviour
{
    private bool isnearObjects;
    public UnityEvent SuassunasObras;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            isnearObjects = true;
            Interact(other);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            isnearObjects = false;
        }
    }

    void Interact(Collider2D other)
    {
        if(CompareTag("Bau 2") && Input.GetKeyDown(KeyCode.Z))
        {
            SuassunasObras.Invoke();
            print("Funciona");
        }
    }




}
