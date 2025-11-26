using UnityEngine;
using UnityEngine.UI;
public class DicaScript2 : MonoBehaviour
{
    public Sprite ligada;
    public Sprite desligada;
    public GameObject dica;
    private Button dicaImg;
    private bool ativada = false;
    private AudioSource dicaAudio;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dicaImg = dica.GetComponent<Button>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
            dicaAudio = GameObject.FindGameObjectWithTag("peixe").GetComponent<AudioSource>();

        if (ativada)
        {
            
            dicaImg.image.sprite = ligada;
        

        }
        else if (!ativada)
        {
            
            dicaImg.image.sprite = desligada;
                dicaAudio.Play();
            
            
        }

       
        
    
    }

    public void ligarLuz()
    {
        if (ativada)
        {
            ativada = false;
      

        }
        else 
        {
            ativada = true;
            
        }
    }
}
