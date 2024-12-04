using TMPro;
using UnityEngine;

public class LifeManeger : MonoBehaviour
{
    public int maxLife;
    public int currentLife;
    public TextMeshProUGUI lifeTxt;

    // Start is called before the first frame update
    void Start()
    {

    }
       
    void UpdateLifeUI()
    {  
       lifeTxt.text = "Vida: " + currentLife.ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Damege"))
        {
            maxLife--;
            UpdateLifeUI();
        }
    }

}
