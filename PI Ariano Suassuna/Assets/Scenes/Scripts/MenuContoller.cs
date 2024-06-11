using UnityEngine;

public class MenuContoller : MonoBehaviour
{
    public GameObject creditsPainel, controlsPainel, levelPainel, phasesPainel;

    public void OpenLevelBTN()
    {
        levelPainel.SetActive(true);
    }
    public void CloseLevelBTN()
    {
        levelPainel.SetActive(false);
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
    public void OpenPhasesBTN()
    {
        controlsPainel.SetActive(true);
    }
    public void ClosePhasesBTN()
    {
        controlsPainel.SetActive(false);
    }
    public void QuitBTN()
    {
        Application.Quit();
        Debug.Log("Quitou");
    }
}
