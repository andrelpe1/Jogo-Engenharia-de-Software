using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject menu_principal;
    public GameObject menuSobre;
    public GameObject menuPontuacao;
    public GameObject menuPontuacao2;
    public GameObject menuSuporte;
    public GameObject menuConfig;
    public GameObject menuComoJogar;
    public GameObject menuComoJogar2;
    private GameObject armazenaVolta;


   
    void Start()
    {
        armazenaVolta = menu_principal;
    }
    void Update()
    {
        
    }

    public void comoJogarProximo()
    {
        menuComoJogar.SetActive(false);
        menuComoJogar2.SetActive(true);
    }

    public void pontuacaoProximo()
    {
        menuPontuacao.SetActive(false);
        menuPontuacao2.SetActive(true);
    }
    public void pontuacaoVoltar()
    {
        menuPontuacao.SetActive(true);
        menuPontuacao2.SetActive(false);
        
    }

    public void comoJogarVoltar()
    {
        menuComoJogar.SetActive(true);
        menuComoJogar2.SetActive(false);
        
    }
    public void sair()
    {
        Application.Quit();
    }

    public void acessarComoJogar()
    {
        menu_principal.SetActive(false);
        menuComoJogar.SetActive(true);
        armazenaVolta = menuComoJogar;
    }

    public void acessarSobre()
    {
        menu_principal.SetActive(false);
        menuSobre.SetActive(true);
        armazenaVolta = menuSobre;
    }

    public void acessarPontuacao()
    {
        menu_principal.SetActive(false);
        menuPontuacao.SetActive(true);
        armazenaVolta = menuPontuacao;
    }

    public void acessarSuporte()
    {
        menu_principal.SetActive(false);
        menuSuporte.SetActive(true);
        armazenaVolta = menuSuporte;
    }

    public void voltarBotao()
    {
        menu_principal.SetActive(true);
        armazenaVolta.SetActive(false);
    }

    public void acessarConfiguracoes()
    {
        if (armazenaVolta != menu_principal)
        {
           armazenaVolta.SetActive(false);
        }
        menu_principal.SetActive(false);
        menuConfig.SetActive(true);
        armazenaVolta = menuConfig;
    }

   

}
