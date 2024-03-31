using UnityEngine;
using UnityEngine.EventSystems;

public class Carta1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform rectTransform;
    private Vector3 originalScale;
    private Vector3 hoverScale = new Vector3(2.5f, 2.5f, 5f);

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale; 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
     
        rectTransform.localScale = hoverScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       
        rectTransform.localScale = originalScale;
    }
}
