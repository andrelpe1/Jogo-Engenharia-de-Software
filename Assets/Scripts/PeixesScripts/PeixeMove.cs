using UnityEngine;

public class PeixeMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float tempoDeVida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject,tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoPeixe();
    }

    private void MovimentoPeixe()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

   
}
