using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "none", 0, "none", Resources.Load<Sprite>("King"), "", Card.Tipo.Melee));
        cardList.Add(new Card(1, "Cabelleros de Leutesia", 6, "no se", Resources.Load<Sprite>("Caballeros"), "MELEE", Card.Tipo.Melee));
        cardList.Add(new Card(2, "Arqueria Leutesiana", 3, "Nozzzzne", Resources.Load<Sprite>("Archers"), "RANGE", Card.Tipo.Distancia));
        cardList.Add(new Card(3, "Catapulta Cromatica", 6, "dsdsd", Resources.Load<Sprite>("Catapulta"), "ASEDIO", Card.Tipo.Asedio));
        cardList.Add(new Card(4, "Sir Leruxe", 1, "dsdsd", Resources.Load<Sprite>("espia"), "espia", Card.Tipo.Melee));
        cardList.Add(new Card(5, "Arthur II", 10, "dsdsd", Resources.Load<Sprite>("Principe"), "Melee", Card.Tipo.Asedio));
    }
}
