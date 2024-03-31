using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<GameObject> cardPrefabs = new List<GameObject>(); 
    private List<GameObject> deck = new List<GameObject>();
    public Transform handTransform;

    void Start()
    {
        if (deck.Count == 0)
        {
            
            FillDeck();

            
            ShuffleDeck();

            
            DrawStartingHand(6);
        }
    }

   
    void FillDeck()
    {
        foreach (GameObject cardPrefab in cardPrefabs)
        {
            deck.Add(cardPrefab);
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
}
