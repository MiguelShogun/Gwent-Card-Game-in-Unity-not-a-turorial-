using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<GameObject> cardPrefabs = new List<GameObject>(); 
    private List<GameObject> deck = new List<GameObject>();
    public List<GameObject> cardPrefabs2 = new List<GameObject>();
    private List<GameObject> deck2 = new List<GameObject>();
    public Transform handTransform;
    public Transform hand2transform;

    void Start()
    {
      
        if (deck.Count == 0)
        {

            FillDeck();


            ShuffleDeck();


            DrawStartingHand(6);
        }

        if (deck2.Count == 0)
        {

            FillDeck2();


            ShuffleDeck2();


            DrawStartingHand2(6);
        }
    }   

   
    void FillDeck()
    {
        foreach (GameObject cardPrefab in cardPrefabs)
        {
            deck.Add(cardPrefab);
        }
       
    }
    void FillDeck2()
    {
        foreach (GameObject cardPrefab in cardPrefabs2)
        {
            
            deck2.Add(cardPrefab);
        }

    }


    void ShuffleDeck()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            GameObject temp = deck[i];
            int randomIndex = Random.Range(i, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }

    }
    void ShuffleDeck2()
    {
        for (int i = 0; i < deck2.Count; i++)
        {
            GameObject temp = deck2[i];
            int randomIndex = Random.Range(i, deck2.Count);
            deck2[i] = deck2[randomIndex];
            deck2[randomIndex] = temp;
        }

    }


    void DrawStartingHand(int numCards)
    {
        for (int i = 0; i < numCards; i++)
        {
            if (deck.Count > 0)
            {
                GameObject cardPrefab = deck[0]; 
                deck.RemoveAt(0); 
                GameObject cardInstance = Instantiate(cardPrefab, handTransform); 

            }
            else
            {
                Debug.Log("No quedan cartas en el mazo.");
                break;
            }
        }
    }
    void DrawStartingHand2(int numCards)
    {
        for (int i = 0; i < numCards; i++)
        {
            if (deck2.Count > 0)
            {
                GameObject cardPrefab = deck2[0];
                deck2.RemoveAt(0);
                GameObject cardInstance = Instantiate(cardPrefab, hand2transform);
                

            }
            else
            {
                Debug.Log("No quedan cartas en el mazo.");
                break;
            }
        }
    }
}
