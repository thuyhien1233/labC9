using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public InputField nameInput;

    public void StartGame()
    {
        // Lấy dữ liệu từ InputField
        GameData.playerName = nameInput.text;

        // Chuyển scene
        SceneManager.LoadScene("Game");
    }
}