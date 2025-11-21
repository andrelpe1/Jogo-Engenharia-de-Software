using UnityEngine;
using UnityEngine.EventSystems;

public class UIHoverAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.Play("Hover"); // nome do seu clip
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.Play("Idle"); // volta para o estado normal
    }
}
