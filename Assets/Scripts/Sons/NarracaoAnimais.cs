using UnityEngine;

public class NarracaoAnimais : MonoBehaviour
{
    public AudioSource source;
    public AudioClip narracao;

    void Start()
    {
        source.clip = narracao;

        if (narracao != null)
            source.Play();

    }
}