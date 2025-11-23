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
<<<<<<< Updated upstream

  
    public int health =3;
=======
    public AudioSource dano;

    public int health = 3;
>>>>>>> Stashed changes
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

        DamageBlink();
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
<<<<<<< Updated upstream
            if(health == 0)
            {
                this.enabled = false;
                PausarAposMorte();
                Time.timeScale = 0;
                uIjogo.SetActive(false);
                fimDeJogo.SetActive(true);
            }
            PlayerPrefs.SetInt("pontuacao_1", score_manager.score_);
=======
            dano.Play();
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            if (health == 0)
            {
                this.enabled = false;
                uIjogo.SetActive(false);
                fimDeJogo.SetActive(true);
                Time.timeScale = 0;
                PlayerPrefs.SetInt("PontTemporaria", score_manager.score_);
                PlayerPrefs.SetInt("VidaTemporaria", health);
              
                
            }
        }
    }

    void DamageBlink()
    {
        if(gameObject.GetComponent<SpriteRenderer>().color == Color.white)
        {

        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(gameObject.GetComponent<SpriteRenderer>().color, Color.white, 5 * Time.deltaTime);
>>>>>>> Stashed changes
        }
    }

    IEnumerator PausarAposMorte()
    {
        yield return null; // espera 1 frame
       
    }
}
