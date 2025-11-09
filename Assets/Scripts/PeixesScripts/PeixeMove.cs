using UnityEngine;

public class PeixeMove : MonoBehaviour
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
