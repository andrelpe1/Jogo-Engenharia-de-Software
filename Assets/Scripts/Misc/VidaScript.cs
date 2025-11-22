using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VidaScript : MonoBehaviour
{
    public GameObject jogador;
    public GameObject vidas;
    private int vida_atual;
    private int vida_anterior = -1;
    private Animator vida_animacao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       vida_animacao = vidas.GetComponent<Animator>();
        vida_animacao.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    // Update is called once per frame
    void Update()
    {
        vida_atual = jogador.GetComponent<PlayerMove>().health;
        if (vida_atual != vida_anterior)
        {
            if (vida_atual == 2)
            {
                vida_animacao.SetTrigger("dano1");
            }
            else if (vida_atual == 1)
            {
                vida_animacao.SetTrigger("dano2");
            }
             if (vida_atual== 0)
            {
                vida_animacao.SetTrigger("danoFinal");
            }
            vida_anterior = vida_atual;
        }
    }
}
