using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class levelManager : MonoBehaviour
{
    public void callLavels()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("fase Atual") + 1);
    }

}
