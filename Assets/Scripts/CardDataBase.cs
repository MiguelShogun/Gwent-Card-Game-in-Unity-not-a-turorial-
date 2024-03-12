using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "none", 0, "none", Resources.Load<Sprite>("King"), ""));
        cardList.Add(new Card(1, "Cabelleros de Leutesia", 6, "no se", Resources.Load<Sprite>("Caballeros"), "MELEE"));
        cardList.Add(new Card(2, "Arqueria Leutesiana", 3, "Nozzzzne", Resources.Load<Sprite>("Archers"), "RANGE"));
        cardList.Add(new Card(3, "Human", 4, "Nzzzzone", Resources.Load<Sprite>("Caballeros"), "RANGE"));
    }
}
