using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class LifeManeger : MonoBehaviour
{
    public int maxLife = 3;
    public int currentLife;
    public TextMeshProUGUI lifeText;
    
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
        UpdateLifeUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamege(int damege)
    {
        if(currentLife < 0)
        {
            currentLife = 0;
        }
        UpdateLifeUI();
    }
    void UpdateLifeUI()
    {
        lifeText.text = "Vida Restante: " + currentLife.ToString();
    }
}
