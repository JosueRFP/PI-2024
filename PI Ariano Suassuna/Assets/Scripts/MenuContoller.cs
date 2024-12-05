using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MenuContoller : MonoBehaviour
{   
    public GameObject creditsPainel, controlsPainel;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    public void Teleport(string tp)
    {
        SceneManager.LoadScene(tp);
    }  
    public void OpenCreditsBTN()
    {
        creditsPainel.SetActive(true);
    }
    public void CloseCreditsBTN()
    {
        creditsPainel.SetActive(false);
    } 
    
    public void OpenControlsBTN()
    {
        controlsPainel.SetActive(true);
    }
    public void CloseControlsBTN()
    {
        controlsPainel.SetActive(false);
    }
   
    public void QuitBTN()
    {
        Application.Quit();
        //Debug.Log("Quitou");
    }
}
