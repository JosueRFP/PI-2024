using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletsQtd : MonoBehaviour
{
    public GameObject Bullet;
    public TextMeshProUGUI bulletQtdTxt;
    public int bulletQtdMax;
    public int bulletQtd;
    // Start is called before the first frame update
    void Start()
    {
        bulletQtdMax = bulletQtd;
        UpdateBulletsTxt();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FireBullets()
    {
        //if(bulletQtdMax -= bulletQtd)
        {
            UpdateBulletsTxt();
        }
    }
    void UpdateBulletsTxt()
    {
        bulletQtdTxt.text = "Munição: /6" + bulletQtdMax;
    }
}
