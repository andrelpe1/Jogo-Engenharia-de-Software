using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.TimeZoneInfo;

public class VidaManagerScriptREAL : MonoBehaviour
{
    public GameObject player;
    private int vidaAtual;
    private Animator animacao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animacao = GetComponent<Animator>();
        animacao.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    // Update is called once per frame
    void Update()
    {
        vidaAtual = player.GetComponent<PlayerMove>().health;
        
        if(vidaAtual == 2)
        {
            animacao.SetTrigger("dano1");
        }
        else if (vidaAtual == 1)
        {
            animacao.SetTrigger("dano2");
        }
        else if (vidaAtual == 0)
        {
            animacao.SetTrigger("danoFinal");
            StartCoroutine(TocarUltimaAnimacao()); 
        }
    }

    IEnumerator TocarUltimaAnimacao()
    {


        yield return null;
        

    }
}


