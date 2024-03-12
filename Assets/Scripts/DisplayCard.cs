using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayID;
    public int id;
    public string cardName;
    public int power;
    public string cardDescription;
    public Sprite spriteImage;

    public TMP_Text nameText;
    public TMP_Text powerText;
    public TMP_Text Description;
    public Image artImage;

    public bool cardisback;
    public static bool CardBack;

    public GameObject CardInHand;
    public int deckcard;



    // Start is called before the first frame update
    void Start()
    {

        displayCard[0] = CardDataBase.cardList[displayID];
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        power = displayCard[0].power;
        cardDescription = displayCard[0].cardDescription;
        spriteImage = displayCard[0].spriteImage;

        nameText.text = "" + cardName;
        powerText.text = "" + power;
        Description.text = "" + cardDescription;
        artImage.sprite = spriteImage;
    }

    // Update is called once per frame
    void Update()
    {
        CardBack = cardisback;

    }
}
