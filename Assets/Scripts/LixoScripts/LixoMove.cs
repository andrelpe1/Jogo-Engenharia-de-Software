using UnityEngine;
using UnityEngine.UIElements;

public class LixoMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float tempoDeVida;
    private float tempoRestante;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tempoRestante = tempoDeVida;
    }

    // Update is called once per frame
    void Update()
    {
        
            MovimentoLixo();
            tempoRestante -= Time.deltaTime;

            if (tempoRestante <= 0f)
            {
                Destroy(gameObject);
            }
    }

    private void MovimentoLixo()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

    
}
