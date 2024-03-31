using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    private Transform meleeZoneTransform;
    private Vector2 startPosition;
    private bool enteredMeleeZone = false;
    private TMP_Text sumaTexto; 
    public int Power = 0;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        startPosition = rectTransform.anchoredPosition; 
        meleeZoneTransform = GameObject.FindGameObjectWithTag("MeleeZone").transform;
        sumaTexto = GameObject.FindGameObjectWithTag("SumaTexto").GetComponent<TMP_Text>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!enteredMeleeZone) 
        {
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        
        if (!enteredMeleeZone)
        {
            rectTransform.anchoredPosition = startPosition; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MeleeZone"))
        {
            enteredMeleeZone = true;
            transform.SetParent(meleeZoneTransform); 
            ActualizarSuma(Power); 
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MeleeZone"))
        {
            enteredMeleeZone = false;
        }
    }
    private void ActualizarSuma(int valor)
    {
        
        int sumaActual = int.Parse(sumaTexto.text);
       
        sumaActual += valor;
        
        sumaTexto.text = sumaActual.ToString();
    }
}
