using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject menu_principal;
    public GameObject menuSobre;
    public GameObject menuPontuacao;
    public GameObject menuSuporte;
    public GameObject menuConfig;
    public GameObject menuComoJogar;
    private GameObject armazenaVolta;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
       
        SceneManager.LoadScene("JogoPeixeDesviar");
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
        menu_principal.SetActive(false);
        menuConfig.SetActive(true);
        armazenaVolta = menuConfig;
    }


}
