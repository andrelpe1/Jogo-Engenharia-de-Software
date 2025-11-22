using NUnit.Framework.Constraints;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpriteSwitch_peixe : MonoBehaviour
{
    public List<Animall> animal_selection;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private TextMeshPro textoNome;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        textoNome = GameObject.FindGameObjectWithTag("Name").GetComponent<TextMeshPro>();
        RandomItens();
    }

    void RandomItens()
    {


        int random_number = Random.Range(0, animal_selection.Count);
        Animall animalEscolhido = animal_selection[random_number];

        // Aplica o sprite base
        spriteRenderer.sprite = animalEscolhido.animal_icon;
        textoNome.text = animalEscolhido.animal_name;
        textoNome.color = Color.blue;
        // Troca o controlador de animação (se tiver)
        if (animalEscolhido.animal_animation != null)
        {
            animator.runtimeAnimatorController = animalEscolhido.animal_animation;
            animator.speed = 0.5f;
        }


        animal_selection.Remove(animal_selection[random_number]);
    }
}
