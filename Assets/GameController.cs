using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text playerNameText;

    void Start()
    {
        playerNameText.text = "Player: " + GameData.playerName;
    }
}