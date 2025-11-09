using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed =0;
    private Renderer rende;// Velocidade de movimento da camada
    private void Start()
    {
        rende = gameObject.GetComponent<Renderer>();
    }
    void Update()
    {
        
            rende.material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
        
    }
}
