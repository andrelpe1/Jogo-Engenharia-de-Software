using Unity.VisualScripting;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [Header("Pontos")]
    [SerializeField] private Transform[] pontosLoc;

    [SerializeField] private GameObject gancho;
    private int pontoAtual=0;

   public float speed;
    public float speed_descida;
    bool descendo= false;
    bool subindo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

    }

    // Update is called once per frame
    private void Update()
    {
        andarProsLados();
       
    }


    private void andarProsLados()
    {
        descendo = false;  
        gancho.transform.position = Vector2.MoveTowards(gancho.transform.position, pontosLoc[pontoAtual].transform.position,speed*Time.deltaTime);
        if (gancho.transform.position == pontosLoc[pontoAtual].transform.position)
        {
            pontoAtual += 1;
             if (pontoAtual >= 2)
            {

                pontoAtual = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && !descendo)
        {
            descendo = true;
            pontoAtual = 2;
        }
    }

    /*void MandarParaBaixo()
    {

        if (!descendo && !subindo)
        {
            
            float deslocamento = Mathf.PingPong(Time.time * speed,1f);
            transform.position = Vector3.Lerp(pontoA.position, pontoB.position, deslocamento);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                descendo = true;  
            }
        }
        else if (descendo && !subindo)
        {
           
            transform.position += Vector3.down * speed_descida * Time.deltaTime;
        }
        MandarParaCima();
    }

    void MandarParaCima()
    {
        if (descendo && Mathf.Abs(transform.position.y - pontoC.position.y) < 0.05f)
        {
            descendo = false; // para de descer
            subindo = true;   // ativa modo de subir (você precisa ter declarado um bool subindo)
        }

        // movimento de subida
        if (subindo)
        {
            transform.position += Vector3.up * speed_descida * Time.deltaTime;
        }
   }*/
}
