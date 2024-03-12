using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Draws : MonoBehaviour
{
  public  GameObject card1;
  public GameObject card2;
  public  GameObject handzone;
  public  GameObject handzone2;
    List<GameObject> carta = new List<GameObject>();
    private void Start()
    {
        carta.Add(card1);
        carta.Add(card2);

    }

    public void OnClick()
    {
        for (int i = 0; i < 1; i++)
        {
            GameObject playercar = Instantiate(carta[Random.Range(0, carta.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playercar.transform.SetParent(handzone.transform, false);
        }
       
    }
}
