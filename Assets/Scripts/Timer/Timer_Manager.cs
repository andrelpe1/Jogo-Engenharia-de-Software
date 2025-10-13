using UnityEngine;
using UnityEngine.UI;
public class Timer_Manager : MonoBehaviour
{
    public Text timer;
    public int tempo;
    private float contador;
    public GameObject game_over;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contador = tempo;
    }

    // Update is called once per frame
    void Update()
    {
        if (contador > 0)
        {
            contador -= Time.deltaTime;
            timer.text = "Timer: " + Mathf.Ceil(contador).ToString();
        }
        else
        {
            game_over.SetActive(true);
        }
    }
}
