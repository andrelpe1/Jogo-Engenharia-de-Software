using UnityEngine;

public class PeixeMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float velocidadeAnimacao;
    [SerializeField] private float tempoDeVida;
    private float tempoRestante;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = velocidadeAnimacao;
        tempoRestante = tempoDeVida;
    }

    // Update is called once per frame
    void Update()
    {
        
            MovimentoPeixe();
            tempoRestante -= Time.deltaTime;

            if (tempoRestante <= 0f)
            {
                Destroy(gameObject);
            }
    }
    

    private void MovimentoPeixe()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

   
}
