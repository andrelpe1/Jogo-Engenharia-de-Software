using UnityEngine;
using UnityEngine.SceneManagement;
public class InGameMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject retornarJogo;
    [SerializeField] private GameObject gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        Time.timeScale = 1;
        gameOver.SetActive(false);
        SceneManager.LoadScene("JogoPeixeDesviar");
    }
}
