using Unity.VisualScripting;
using UnityEngine;

public class PlayerMoveFaseEscolha : MonoBehaviour
{
    public float speed = 2f;
    public static int pontuacao = 0;
    public string tipoAnimal;
    public ScoreFase2 score_manager;
    private Rigidbody2D rb;

    private AudioSource som1;
    private AudioSource som2;

    public Color cor_animal;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        GameObject obj = GameObject.FindGameObjectWithTag("Score");
        if (obj == null)
        {
            Debug.LogError("ERRO: Nao existe GameObject com TAG 'Score' na cena!");
            return;
        }

        score_manager = obj.GetComponent<ScoreFase2>();
        if (score_manager == null)
        {
            Debug.LogError("ERRO: GameObject com TAG 'Score' nao tem ScoreFase2!");
        }


        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreFase2>();
        som1 = GameObject.FindGameObjectWithTag("SomCerto").GetComponent<AudioSource>();
        som2 = GameObject.FindGameObjectWithTag("SomErrado").GetComponent<AudioSource>();
    }

    void Update()
    {
        MoveWithWASD();
    }

    void MoveWithWASD()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveX, moveY).normalized;
        rb.linearVelocity = movement * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Caixa"))
        {

            CaixaTipoScript caixa = other.GetComponent<CaixaTipoScript>();

            if (caixa != null)
            {
                if (caixa.tipoAceito == tipoAnimal)
                {
                    score_manager.score_2 += 1;
                    som1.Play();
                }
                else
                {
                    som2.Play();
                }

                    
                    
            }
            GetComponent<AleatorizarNome>().DestruirAntigos();
            Destroy(this.gameObject, 0);
        }
    }
}