using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject player1Hand;
    public GameObject player2Hand;

    private bool player1Turn = true;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void EndTurn()
    {
        player1Turn = !player1Turn;

        
        if (player1Turn)
        {
            EnableInteractions(player1Hand);
            SetCardVisibility(player1Hand, true);
            DisableInteractions(player2Hand);
            SetCardVisibility(player2Hand, false);
        }
        else
        {
            EnableInteractions(player2Hand);
            SetCardVisibility(player2Hand, true);
            DisableInteractions(player1Hand);
            SetCardVisibility(player1Hand, false);
        }
    }

    void EnableInteractions(GameObject playerHand)
    {
        DragAndDrop[] cards = playerHand.GetComponentsInChildren<DragAndDrop>();
        foreach (var card in cards)
        {
            card.enabled = true; 
        }
    }

    void DisableInteractions(GameObject playerHand)
    {
        DragAndDrop[] cards = playerHand.GetComponentsInChildren<DragAndDrop>();
        foreach (var card in cards)
        {
            card.enabled = false; 
        }
    }

    void SetCardVisibility(GameObject playerHand, bool isVisible)
    {
        foreach (Transform card in playerHand.transform)
        {
           
            Transform cardImage = card.Find("Foto");

            if (cardImage != null)
            {
              
                cardImage.gameObject.SetActive(isVisible);
            }
        }
    }
}
