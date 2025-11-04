using UnityEngine;
using UnityEngine.UIElements;

public class LixoMove : MonoBehaviour
{
    [SerializeField] private float speed;
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
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
