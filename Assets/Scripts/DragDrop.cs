using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    private bool m_IsDragging;
    private bool its_over_zone;
    GameObject dropzone;
    private Vector2 starPosition;


    private void Update()
    {
        if (m_IsDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        its_over_zone = true;
        dropzone = collision.gameObject;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        its_over_zone = false;
        dropzone = null;
    }
    public void OnStarDrag()
    {
        starPosition = transform.position;
        m_IsDragging = true;
    }

    public void OnEndDrag()
    {
        m_IsDragging = false;
        if (its_over_zone)
        {
            transform.SetParent(dropzone.transform, false);
        }
        else
        {
            transform.position = starPosition;
        }


    }




}
