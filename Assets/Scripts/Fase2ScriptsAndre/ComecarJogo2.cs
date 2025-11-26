using UnityEngine;

public class ComecarJogo2 : MonoBehaviour
{
    private int pontos;
    private string nome;
    private int vida;
    private string resultado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void juntarDados()
    {
        pontos = PlayerPrefs.GetInt("AcertosTemporaria");
        nome = PlayerPrefs.GetString("NomeTemporario");
        vida = PlayerPrefs.GetInt("ErrosTemporaria");
        Debug.Log("pont:" + pontos + "nome" + nome + "erros" + vida);
        if (pontos == 10)
        {
            resultado = "perfeito";
        }
        else if (pontos == 9)
        {
            resultado = "ótimo";
        }
        else if (pontos == 7 || pontos == 8)
        {
            resultado = "bom";
        }
        else if (pontos == 6 || pontos == 5)
        {
            resultado = "mediano";
        }
        else
        {
            resultado = "ruim";
        }

        HighScore2.Instance.AddHighScoreEntry(pontos, nome, vida, resultado);
    }
}
