using Unity.VisualScripting;
using UnityEngine;

public class PlayerMoveFaseEscolha : MonoBehaviour
{
    public float speed = 2f;
    public static int pontuacao = 0;
    public string tipoAnimal;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
                    pontuacao += 1;
                    Debug.Log("Pontuação: " + pontuacao);
                }
            }

            Debug.Log("Pontuação: " + pontuacao);

            Destroy(this.gameObject, 0);
        }
    }
}