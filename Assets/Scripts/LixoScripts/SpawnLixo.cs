using Unity.VisualScripting;
using UnityEngine;

public class SpawnLixo : MonoBehaviour
{
     private float cooldown_;
    [SerializeField] private float tempo;

    [SerializeField] private float x, y;
    [SerializeField] private GameObject lixo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown();
    }

    void Cooldown()
    {
        if (cooldown_ <= 0)
        {
            SpawnObstacle();
            cooldown_ = tempo;
        }
        else
        {
            cooldown_ -= Time.deltaTime;
        }
    }

    void SpawnObstacle()
    {
        GameObject lixoDireita = Instantiate(lixo, new Vector3(x, y, 0), Quaternion.identity);
        //lixoDireita.GetComponent<LixoMove>().alvo = GameObject.FindGameObjectWithTag("p1").transform;

        // Instancia à esquerda
        GameObject lixoEsquerda = Instantiate(lixo, new Vector3(-x, y, 0), Quaternion.identity);
        //lixoEsquerda.GetComponent<LixoMove>().alvo = GameObject.FindGameObjectWithTag("p2").transform;
    }


}
