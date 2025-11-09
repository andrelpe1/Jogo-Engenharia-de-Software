using Unity.VisualScripting;
using UnityEngine;

public class Peixe_Spawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float cooldown_;
    [SerializeField] private float tempo;

    [SerializeField] private float x, y;
    [SerializeField] private GameObject peixe;
    [SerializeField] private Score_ManagerScript score_manager;
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
        GameObject peixeDi = Instantiate(peixe, new Vector3(x, Random.Range(-5, 5), 0), Quaternion.identity);
    }
}
