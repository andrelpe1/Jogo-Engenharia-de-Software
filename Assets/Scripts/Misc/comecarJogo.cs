
using UnityEngine;

public class comecarJogo : MonoBehaviour
{
    private int pontos;
    private string nome;
    private int vida;
    private string resultado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HighScore existe? " + (HighScoreTable.Instance != null));
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void juntarDados()
    {
        pontos = PlayerPrefs.GetInt("PontTemporaria");
        nome = PlayerPrefs.GetString("NomeTemporario");
        vida = PlayerPrefs.GetInt("VidaTemporaria");
        if((vida ==3) && (pontos == 10)){
            resultado = "perfeito";
        }else if ((vida == 2) && (pontos == 10))
        {
            resultado = "ótimo";
        }else if((vida == 1) && (pontos == 10))
        {
            resultado = "bom";
        }else if ((vida == 0) && (pontos < 10)&& (pontos>=6))
        {
            resultado = "mediano";
        }
        else
        {
            resultado = "ruim";
        }

        HighScoreTable.Instance.AddHighScoreEntry(pontos, nome, vida, resultado);
    }
}
