using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropClime : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
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

        meleeZoneTransform = GameObject.FindGameObjectWithTag("ZonaClima").transform;
        sumaTexto = GameObject.FindGameObjectWithTag("SumaTexto").GetComponent<TMP_Text>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = rectTransform.anchoredPosition;
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
        if (collision.gameObject.CompareTag("ZonaClima"))
        {
            enteredMeleeZone = true;
            transform.SetParent(meleeZoneTransform);
            //ActualizarSuma1(Power);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ZonaClima"))
        {
            enteredMeleeZone = false;
        }
    }
}
