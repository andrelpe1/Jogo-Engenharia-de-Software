using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   [SerializeField] private float move_speed;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        WasdMove();
    }

    private void WasdMove()
    {
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(0, vertical).normalized;
        rb.linearVelocity = direction * move_speed;
    }

}
