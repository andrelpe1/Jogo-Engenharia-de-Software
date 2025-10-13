using UnityEngine;

public class LixoMove : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform alvo;
    public bool pegado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 5);
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
