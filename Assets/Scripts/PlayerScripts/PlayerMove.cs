using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   [SerializeField] private float move_speed;
    private Rigidbody2D rb;
    private Animator animator_;
    private float speed_anima;
    public GameObject fimDeJogo;
    public GameObject uIjogo;
    public Score_ManagerScript score_manager;

  
    public int health =3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator_ = GetComponent<Animator>();
        speed_anima = animator_.speed;
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<Score_ManagerScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
            WasdMove();
         
  
    }

    private void WasdMove()
    {
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(0, vertical).normalized;
        rb.linearVelocity = direction * move_speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("lixo"))
        {
            health--;
            if(health == 0)
            {
                this.enabled = false;
                PausarAposMorte();
                Time.timeScale = 0;
                uIjogo.SetActive(false);
                fimDeJogo.SetActive(true);
            }
            PlayerPrefs.SetInt("pontuacao_1", score_manager.score_);
        }
    }

    IEnumerator PausarAposMorte()
    {
        yield return null; // espera 1 frame
       
    }
}
