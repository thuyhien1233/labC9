using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Khai báo 1 biến để nhét cái file config vào
    public GameConfig myConfig;

    void Start()
    {
        // Khi game bắt đầu, in ra các thông số để test
        Debug.Log("Máu của người chơi: " + myConfig.maxHealth);
        Debug.Log("Tốc độ chạy: " + myConfig.playerSpeed);
    }
}