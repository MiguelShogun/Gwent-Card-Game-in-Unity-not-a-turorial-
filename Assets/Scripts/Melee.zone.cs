using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToMove : MonoBehaviour
{
    public GameObject meleeZone;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log("Collider hit: " + hit.collider.gameObject.name);
                if (hit.collider.CompareTag("Card"))
                {
                    Debug.Log("Card clicked!");
                    Transform cardTransform = hit.collider.transform;
                    cardTransform.SetParent(meleeZone.transform); // Establecer la zona melee como el nuevo padre
                    cardTransform.localPosition = Vector3.zero; // Posicionar la carta en el centro de la zona melee
                    cardTransform.localScale = Vector3.one; // Restaurar la escala de la carta
                }
            }
            else
            {
                Debug.Log("No collider hit.");
            }
        }
    }
}
