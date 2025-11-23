using UnityEngine;
using UnityEngine.UI;

public class VidaManagerScript : MonoBehaviour
{
    public Sprite ligada;
    public Sprite desligada;
    public GameObject dica;
    public Button dicaImg;
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
        if (Time.timeScale == 1)
        {
            dicaImg.image.sprite = ligada; 
            Time.timeScale = 0.5f;
        }
        else if (Time.timeScale == 0.5)
        {
            dicaImg.image.sprite = desligada;
            Time.timeScale = 1;
        } else if (Time.timeScale == 0){
            dicaImg.image.sprite = desligada;
        }
    }
}
