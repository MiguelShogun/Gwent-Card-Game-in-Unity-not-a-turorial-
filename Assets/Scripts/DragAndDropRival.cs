using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DragAndDrop1 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
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

        meleeZoneTransform = GameObject.FindGameObjectWithTag("MeleeZone1").transform;
        sumaTexto = GameObject.FindGameObjectWithTag("SumaTexto1").GetComponent<TMP_Text>();
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
        if (collision.gameObject.CompareTag("MeleeZone1"))
        {
            enteredMeleeZone = true;
            transform.SetParent(meleeZoneTransform);
            ActualizarSuma1(Power);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MeleeZone1"))
        {
            enteredMeleeZone = false;
        }
    }
    private void ActualizarSuma1(int valor)
    {

        if (sumaTexto != null)
        {
            int sumaActual = int.Parse(sumaTexto.text);
            sumaActual += valor;
            sumaTexto.text = sumaActual.ToString();
        }
        else
        {
            Debug.LogError("sumaTexto is null in ActualizarSuma1()");
        }
    }
}
