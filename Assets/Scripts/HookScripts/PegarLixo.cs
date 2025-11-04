using UnityEngine;

public class PegarLixo : MonoBehaviour
{
    [SerializeField] private float speed;
    [Header("Pontos")]
    [SerializeField] private Transform[] pontosLoc;

    private int pontoAtual = 0;

    public float speed_descida;
    bool descendo = false;
    bool subindo = false;
    bool indoLado = true;
    public Score_ManagerScript score_manager;
    void Start()
    {
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<Score_ManagerScript>();

    }
    private void Update()
    {
        if (indoLado)
            andarProsLados();
        else if (descendo)
            Descer();
        else if (subindo)
            Subir();

        if (Input.GetKeyDown(KeyCode.Space) && !descendo && !subindo)
        {
            indoLado = false;
            descendo = true;
        }

    }


    private void andarProsLados()
    {
      transform.position = Vector2.MoveTowards(transform.position, pontosLoc[pontoAtual].transform.position, speed * Time.deltaTime);
            if (transform.position == pontosLoc[pontoAtual].transform.position)
            {
                pontoAtual += 1;
                if (pontoAtual >= 2)
                {
                    pontoAtual = 0;
                }
        }
            
    }


    private void Descer()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void Subir()
    {
        transform.position = Vector2.MoveTowards(transform.position, pontosLoc[3].transform.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, pontosLoc[3].position) < 0.05f)
        {
            
            subindo = false;
            indoLado = true;
            pontoAtual = (pontoAtual == 0) ? 1 : 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("lixo") && descendo)
        {
            descendo = false;
            subindo = true;
            pontoAtual = 3;
           

            score_manager.score_ += 1;
        }
        if (collision.gameObject.CompareTag("wall"))
        {
            descendo = false;
            subindo = true;
            pontoAtual = 3;
        }
        if (collision.gameObject.CompareTag("peixe") && descendo)
        {
            descendo = false;
            subindo = true;
            pontoAtual = 3;
           // collision.GetComponent<PeixeMove>().alvo = this.transform;

            score_manager.score_ -= 1;
        }
    }
}
