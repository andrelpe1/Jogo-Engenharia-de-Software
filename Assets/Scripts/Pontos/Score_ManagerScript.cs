using UnityEngine;
using UnityEngine.UI;
public class Score_ManagerScript : MonoBehaviour
{
    public Text pontuacao;
    public int score_;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pontuacao != null)
            pontuacao.text = "Score: "+score_.ToString();
    }
}
