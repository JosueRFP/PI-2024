using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class levelManager : MonoBehaviour
{
    public Button[] bot�es;

    private void Update()
    {
        for (int i = 0; i< bot�es.Length; i = i++)
        {
           
        }
    }
    
    public void callLavels()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("fase Atual") + 1);
    }

}
