using UnityEngine;
using UnityEngine.UI;
public class Score_ManagerScript : MonoBehaviour
{
    public Text pontuacao;
    public Text total;
    public int score_= 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pontuacao != null)
            pontuacao.text = "Pontos: "+score_.ToString();
            total.text = "Sua pontuação foi: " + score_.ToString() + "/10";
    }
}
