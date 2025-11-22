using System.Collections.Generic;
using UnityEngine;

public class PeixesFundoScript : MonoBehaviour
{
    private float cooldown_;
    [SerializeField] private float tempo;

    [SerializeField] private float x, y;
    [SerializeField] private List<GameObject> peixes;
    private int numPeixe=9; 
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
            cooldown_ = tempo;//(tempo - (score_manager.score_ / 10)); ;
        }
        else
        {
            cooldown_ -= Time.deltaTime;
        }
    }

    void SpawnObstacle()
    {
        if (numPeixe == 0)
        {
            numPeixe = 9;
        }
        GameObject peixeDi = Instantiate(peixes[numPeixe], new Vector3(x, Random.Range(-4.2f, 4.4f), 0), Quaternion.identity);
        numPeixe--;
    }
}
