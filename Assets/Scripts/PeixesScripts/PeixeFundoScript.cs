using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PeixeFundoScript : MonoBehaviour
{
    public List<GameObject> peixes;
    private int pos = 9;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float cooldown_;
    [SerializeField] private float tempo;

    [SerializeField] private float x, y;
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
        if (pos == 0)
        {
            pos = 9;
        }
        GameObject peixeDi = Instantiate(peixes[pos], new Vector3(x, Random.Range(-4.2f, 4.02f), 0), Quaternion.identity);
        pos--;
    }
}
