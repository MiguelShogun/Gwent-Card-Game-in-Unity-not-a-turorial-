using UnityEngine;
using UnityEngine.UI;

public class EndTurnButton : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(EndTurn);
    }

    void EndTurn()
    {
        GameManager.instance.EndTurn();
    }
}
