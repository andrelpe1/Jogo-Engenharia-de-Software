using UnityEngine;
using UnityEngine.UI;

public class ScoreFase2 : MonoBehaviour
{
    public Text pontuacao;
    public Text total;
    public int score_2 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pontuacao != null)
            pontuacao.text = "Pontos: " + score_2.ToString();
            total.text = "Sua pontuação foi: " + score_2.ToString() + "/10";
    }
}
