using UnityEngine;

public class LixoMove : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform alvo;
    public bool pegado = false;
    [SerializeField] private float tempoDeVida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoLixo();
    }

    private void MovimentoLixo()
    {
        if (!pegado)
        {
            transform.position = Vector2.MoveTowards(transform.position, alvo.position, speed * Time.deltaTime);
        }
    }
}
