using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BotaoScript : MonoBehaviour
{
    [SerializeField] private List<Sprite> estados;
    private Image botao;
    private 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
            botao = GetComponent<Image>();
        botao.sprite = estados[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            botao.sprite = estados[0];
        }
    }

   public void Clicar()
    {
        if (botao.sprite == estados[0])
        {
            botao.sprite = estados[1];
        }
        else
        {
            botao.sprite = estados[0];
        }
    }
}
