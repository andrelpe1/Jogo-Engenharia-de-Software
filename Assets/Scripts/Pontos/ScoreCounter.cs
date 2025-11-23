using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public Score_ManagerScript score_manager;
    public AudioSource coletar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<Score_ManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Moeda"))
        {
            coletar.Play();
            score_manager.score_ += 1;
            Destroy(collision.gameObject);
        }
    }
}
