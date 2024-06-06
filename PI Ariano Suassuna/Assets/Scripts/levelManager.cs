using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class levelManager : MonoBehaviour
{
    public Button[] botões;

    private void Update()
    {
        for (int i = 0; i< botões.Length; i = i++)
        {
           
        }
    }
    
    public void callLavels()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("fase Atual") + 1);
    }

}
