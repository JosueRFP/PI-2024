using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : MonoBehaviour
{
    public Transform Player;
    public bool correrDoJogador = false;
    public float detectorDaDistancia;
    public float velEvasao = 5f;
    public float distEvasao = 5f;
    public float tempEvasao = 5f;
    public bool estaEvadindo = false;

    private Vector2 direcaoDaEvasao;
    private float tempDeEvasao = 0f;
    
    
    // Update is called once per frame
    void Update()
    {
        float distEvasao = Vector2.Distance(transform.position, Player.position);
        if(distEvasao <= detectorDaDistancia && !estaEvadindo)
        {
            StartEvadindo();
        }
        if (estaEvadindo)
        {
            EvadindoMov();
        }
    }

    void StartEvadindo()
    {
        estaEvadindo = true;
        tempDeEvasao = tempEvasao;

        //Determina a direção oposta ao jogodor
        direcaoDaEvasao = (transform.position - Player.position).normalized;
    }

    void EvadindoMov()
    {
        tempDeEvasao -= Time.deltaTime;
        
        if(tempDeEvasao <= 0)
        {
            estaEvadindo = false;
            return;
        }

        // Move na direção oposta ao jogador
        transform.Translate(direcaoDaEvasao * velEvasao * Time.deltaTime);

    }
}
