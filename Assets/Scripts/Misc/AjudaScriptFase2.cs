using UnityEngine;
using UnityEngine.UI;

public class AjudaManagerScript2 : MonoBehaviour
{
    public Sprite ligada;
    public Sprite desligada;
    public GameObject dica;
    public Button dicaImg;
    public bool ligadoDica;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dicaImg = dica.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ligarLuz()
    {

        if (ligadoDica)
        {
            dicaImg.image.sprite = desligada;
            ligadoDica = false;
        }
        else
        {
            dicaImg.image.sprite = ligada;
            ligadoDica = true;
        }
    }
}
