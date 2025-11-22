using Unity.VisualScripting;
using UnityEngine;

public class PlayerMoveFaseEscolha : MonoBehaviour
{
    public float speed = 2f;
    public static int pontuacao = 0;
    public string tipoAnimal;
    public ScoreFase2 score_manager;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreFase2>();
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
                }
                
            }

            Destroy(this.gameObject, 0);
        }
    }
}