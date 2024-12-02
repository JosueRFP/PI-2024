using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public Text speechTxt;
    public Text actorNameTXT;

    [Header("Settings")]
    public float typingSpeed;


    public void Speech(Sprite p, string txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        speechTxt.text = actorName;  //video ta no minuto 5:18 e falta criar o script dialogue e anexar  ao npc q qro a arte da alicia 
    }



}
