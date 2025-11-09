using UnityEngine;
using UnityEngine.UI;
public class PontosManagerMenu : MonoBehaviour
{
    private int pontos;
    public Text fase1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pontos =PlayerPrefs.GetInt("pontuacao_1");
    }

    // Update is called once per frame
    void Update()
    {
        fase1.text = "Fase 1: " + pontos;
    }
}
