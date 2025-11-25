using Unity.VisualScripting;
using UnityEngine;

public class PlayerMoveFaseEscolha : MonoBehaviour
{
    public float speed = 2f;
    public static int pontuacao = 0;
    public string tipoAnimal;
    public ScoreFase2 score_manager;
    private Rigidbody2D rb;
    public AudioSource sourceGanho;
    public AudioSource sourcePerca;
    public Sprite spriteNormal;
    public Sprite spriteColorido;
    public GameObject AjudaFase2;
    private bool ligado;



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
    }

    void Update()
    {
        ligado = AjudaFase2.GetComponent<AjudaManagerScript2>().ligadoDica;

        if (ligado)
        {
            this.GetComponent<SpriteRenderer>().sprite = spriteColorido;

            transform.localScale = new Vector3(9.2598f, 10.57527f, 1f);

        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = spriteNormal;
            transform.localScale = new Vector3(0.32f, 0.39f, 1f);
        }

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
                    sourceGanho.Play();
                }
                else
                {
                    sourcePerca.Play();
                }
                
            }

            Destroy(this.gameObject, 0);
        }
    }
}