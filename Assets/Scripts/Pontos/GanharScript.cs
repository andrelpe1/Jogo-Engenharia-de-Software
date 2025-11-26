using UnityEngine;

public class GanharScript : MonoBehaviour
{
    public GameObject score_manager;
    private int score_count;
    [SerializeField] private GameObject ganharTela;
    [SerializeField] private GameObject player;
    private int vida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        vida = player.GetComponent<PlayerMove>().health;
        score_count = score_manager.GetComponent<Score_ManagerScript>().score_;
        ganhar();
    }

    private void ganhar()
    {
        if (score_count == 10)
        {
            Time.timeScale = 0;
           
            ganharTela.SetActive(true);
        }

        PlayerPrefs.SetInt("VidaTemporaria", vida);
        PlayerPrefs.SetInt("PontTemporaria", score_count);
    }
}
