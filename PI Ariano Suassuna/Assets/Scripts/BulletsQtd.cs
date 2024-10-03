using TMPro;
using UnityEngine;

public class BulletsQtd : MonoBehaviour
{
    public GameObject Bullet;
    public TextMeshProUGUI bulletQtdTxt;
    public int bulletQtdMax = 6;
    public int bulletQtd;
    // Start is called before the first frame update
    void Start()
    {
        bulletQtd = bulletQtdMax;
        UpdateBulletsTxt();
    }

    void FireBullets()
    {
        if(bulletQtdMax >= 6)
        {
            bulletQtdMax--;
            UpdateBulletsTxt();
        }
    }
    void UpdateBulletsTxt()
    {
        bulletQtdTxt.text = "Munição: " + bulletQtdMax;
    }
}
