using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject historyPainel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetButtonDown("e"))
        {
            if(collision.gameObject.CompareTag("Player")) 
            {
                historyPainel.SetActive(true);
            }

        }
        
    }
}
