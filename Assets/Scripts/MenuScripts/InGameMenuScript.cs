using NUnit.Framework;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InGameMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject retornarJogo;
    [SerializeField] private GameObject gameOver;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
<<<<<<< Updated upstream
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
=======
    
>>>>>>> Stashed changes

    public void ajuda()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0.5f;
        }else if((Time.timeScale == 0.5f) || (Time.timeScale == 0))
        {
            Time.timeScale = 1;
        }

        
    }
    public void voltarJogo()
    {

        ajuda();
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
<<<<<<< Updated upstream
=======

    public void JogarNovamenteFase2()
    {
        
        gameOver.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("JogoDividirAnimais");
    }
>>>>>>> Stashed changes
}
