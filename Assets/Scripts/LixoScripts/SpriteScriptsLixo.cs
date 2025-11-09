using System.Collections.Generic;
using UnityEngine;

public class SpriteScriptsLixo : MonoBehaviour
{
    public List<Trash> trash_selection;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        RandomItens();
    }

    void RandomItens()
    {
        if (trash_selection == null || trash_selection.Count == 0)
        {
            Debug.LogWarning("Nenhum item de lixo foi atribuído!");
            return;
        }

        int random_number = Random.Range(0, trash_selection.Count);
        Trash lixoEscolhido = trash_selection[random_number];

        // Aplica o sprite base
        spriteRenderer.sprite = lixoEscolhido.trash_icon;

        // Troca o controlador de animação (se tiver)
        if (lixoEscolhido.trash_animation != null)
        {
            animator.runtimeAnimatorController = lixoEscolhido.trash_animation;
            animator.speed = 0.5f;
        }
    }

  
}
