using UnityEngine;

public class NarrarFASE1 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Tocar"))
        {
            Debug.Log("Passou no ponto!");
            collision.gameObject.GetComponent<AudioSource>().Play();

        }
    }
}
