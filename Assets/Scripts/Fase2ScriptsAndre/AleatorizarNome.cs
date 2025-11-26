using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.UI;

public class AleatorizarNome : MonoBehaviour
{
    public List<String> animais_nome;
    public GameObject animais_;
    private int index;
    public int num_aleatorio;
    public Color cor;

    [SerializeField] private List<float>  y;
    [SerializeField] private float x = 7.08f;

  
    private List<GameObject> clones = new List<GameObject>();
    private List<string> availableNames;      // lista que vamos sortear e remover
    private List<string> originalNames;
    private String peixe_certo;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // faz cópia imutável das referências originais
        originalNames = new List<string>(animais_nome);
        // lista que usaremos para sortear/remover sem mexer na original
        availableNames = new List<string>(animais_nome);

        peixe_certo = GetComponent<PlayerMoveFaseEscolha>().tipoAnimal;
  

        int[] numeros = { 0, 1, 2, 3 };
        numeros = numeros.OrderBy(x => UnityEngine.Random.value).ToArray();
        
        gerarCorreto(numeros[0]);
        gerarTextos(numeros[1]);
        gerarTextos(numeros[2]);
        gerarTextos(numeros[3]);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void gerarTextos(int index_caixa)
    {
        if (availableNames == null || availableNames.Count == 0)
        {
            Debug.LogWarning("Nenhum nome disponível para gerarTexto.");
            return;
        }

        int randIndex = UnityEngine.Random.Range(0, availableNames.Count);
        string texto = availableNames[randIndex];

        GameObject animal_atual = Instantiate(animais_, new Vector3(x, y[index_caixa], 0), Quaternion.identity);
        clones.Add(animal_atual);

        int originalIndex = originalNames.IndexOf(texto);
        Color corTexto = atriburCor(originalIndex);


        TMP_Text tmp = animal_atual.GetComponentInChildren<TMP_Text>();
        if (tmp == null)
        {
            Debug.LogWarning("TMP_Text não encontrado no prefab 'animais_'.");
        }
        else
        {
            tmp.text = texto;
            tmp.color = corTexto;
        }

        // seta tipoAceito se existir
        var caixaScript = animal_atual.GetComponent<CaixaTipoScript>();
        if (caixaScript != null)
            caixaScript.tipoAceito = texto;
        else
            Debug.LogWarning("CaixaTipoScript não encontrado no clone.");

        // remove da lista de disponíveis (não toca na original)
        availableNames.RemoveAt(randIndex);
    }

   
    public void DestruirAntigos()
    {
        foreach (GameObject clone in clones)
        {
            if (clone != null)
                Destroy(clone);
        }

        clones.Clear();

    }


    private Color atriburCor(int originalIndex)
    {
        if (originalIndex < 0) return Color.white;

        // use cores válidas do Unity (criei orange com Color32)
        if (originalIndex < 3) return new Color32(255, 165, 0, 255); // laranja
        if (originalIndex < 6) return Color.yellow;
        if (originalIndex < 8) return Color.red;
        return Color.green;
    }
    private void gerarCorreto(int index_caixa)
    {
        int idxOriginal = originalNames.IndexOf(peixe_certo);
        if (idxOriginal < 0)
        {
            Debug.LogWarning("Peixe certo não encontrado em originalNames: " + peixe_certo);
            return;
        }

        // instancia o clone
        GameObject animal_atual = Instantiate(animais_, new Vector3(x, y[index_caixa], 0), Quaternion.identity);
        clones.Add(animal_atual);

        TMP_Text tmp = animal_atual.GetComponentInChildren<TMP_Text>();
        if (tmp != null)
        {
            tmp.text = peixe_certo;
            tmp.color = atriburCor(idxOriginal);
        }
        else Debug.LogWarning("TMP_Text não encontrado no prefab 'animais_'.");

        // define tipoAceito
        var caixaScript = animal_atual.GetComponent<CaixaTipoScript>();
        if (caixaScript != null)
            caixaScript.tipoAceito = peixe_certo;

        // remover peixe_certo da lista de disponíveis (para não duplicar)
        // procuramos na availableNames, pois originalNames permanece intacta
        int posDisponivel = availableNames.IndexOf(peixe_certo);
        if (posDisponivel >= 0)
            availableNames.RemoveAt(posDisponivel);


    }


}
