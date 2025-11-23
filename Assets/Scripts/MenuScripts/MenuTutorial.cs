using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuTutorial : MonoBehaviour
{
    [SerializeField] private List<GameObject> tutorial;
    [SerializeField] private InputField campo_nome;
    public void sair()
    {
        SceneManager.LoadScene("Menu");
    }

    public void iniciar()
    {
        SceneManager.LoadScene("JogoPeixeDesviar");
    }

    public void enviarNome()
    {
        if (campo_nome.text != "")
        {
            PlayerPrefs.SetString("NomeTemporario", campo_nome.text);
            tutorial[0].SetActive(false);
            tutorial[1].SetActive(true);
        }
    }
}
