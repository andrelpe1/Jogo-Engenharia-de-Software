using UnityEngine;
using UnityEngine.SceneManagement;
public class InGameMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject retornarJogo;
    [SerializeField] private GameObject gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    public void voltarJogo()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        retornarJogo.SetActive(true);
    }

    public void voltarMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void abrirConf()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
        retornarJogo.SetActive(false);
    }

    public void JogarNovamente()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("JogoPeixeDesviar");
        
    }

    public void JogarNovamenteFase2()
    {
        
        gameOver.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("JogoDividirAnimais");
    }
}
