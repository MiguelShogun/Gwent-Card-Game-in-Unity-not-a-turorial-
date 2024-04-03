using UnityEngine;
using UnityEngine.EventSystems;



public class ScaleObjectOnStart : MonoBehaviour
{
    public Vector2 targetScale = new Vector2(2f, 2f); // Escala final deseada
    public float scaleTime = 2f; // Tiempo que tardará en alcanzar la escala final

    private Vector2 initialScale;
    private float currentTime = 0f;
    private bool scaling = false;

    void Start()
    {
        initialScale = transform.localScale;
        scaling = true;
    }

    void Update()
    {
        if (scaling)
        {
            currentTime += Time.deltaTime;
            float t = Mathf.Clamp01(currentTime / scaleTime);
            transform.localScale = Vector2.Lerp(initialScale, targetScale, t);

            if (t >= 1f)
            {
                scaling = false;
            }
        }
    }
}