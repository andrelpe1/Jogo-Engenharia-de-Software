using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed; // Velocidade de movimento da camada
    private float startPosX;
    public float repeatWidth;

    void Start()
    {
        startPosX = transform.position.x;
    }

    void Update()
    {
        // Move a camada para a esquerda
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Reinicia a posição pra dar efeito de loop infinito
        if (transform.position.x < startPosX - repeatWidth)
        {
            transform.position = new Vector2(startPosX, transform.position.y);
        }
    }
}
