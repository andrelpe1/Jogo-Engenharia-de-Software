using UnityEngine;

public class Ganhar2 : MonoBehaviour
{
    public GameObject score_manager;
    private int score_count;
    
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score_count = score_manager.GetComponent<ScoreFase2>().score_2;
        ganhar();
    }

    private void ganhar()
    {

        PlayerPrefs.SetInt("ErrosTemporaria", 10-score_count);
        PlayerPrefs.SetInt("AcertosTemporaria", score_count);
    }
}
