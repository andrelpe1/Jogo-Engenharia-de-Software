using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class AnimalSequencer : MonoBehaviour
{
    public List<GameObject> animalPrefabs;  // lista com os prefabs dos peixes
    public Transform spawnPoint;            // posição inicial de spawn
    private int currentIndex = 0;
    private GameObject currentAnimal;
    public GameObject telaFim;
    public bool jogoAcabou = false;

    void Start()
    {
        SpawnNextAnimal();
    }

    void Update()
    {

        if (jogoAcabou) return;


        if (currentAnimal == null || !currentAnimal.activeInHierarchy)
        {
            SpawnNextAnimal();
        }
    }

    void SpawnNextAnimal()
    {

        if(currentIndex >= animalPrefabs.Count)
        {
            telaFim.SetActive(true);
            jogoAcabou = true;
            return;
        }


        currentAnimal = Instantiate(animalPrefabs[currentIndex], spawnPoint.position, Quaternion.identity);
        AudioSource src = currentAnimal.GetComponent<AudioSource>();
        NarracaoAnimais voice = currentAnimal.GetComponent<NarracaoAnimais>();


        if (src != null && voice != null && voice.narracao != null)
        {
            src.PlayOneShot(voice.narracao);
        }

        currentIndex++;

    }
}