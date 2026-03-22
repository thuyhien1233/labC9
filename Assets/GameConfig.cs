using UnityEngine;

// Dòng này giúp tạo menu chuột phải trong Unity để bạn dễ dàng tạo ra file data
[CreateAssetMenu(fileName = "NewGameConfig", menuName = "Game Data/Game Config")]
public class GameConfig : ScriptableObject // CHÚ Ý: Đổi MonoBehaviour thành ScriptableObject
{
    // Khai báo các thông số bạn muốn lưu
    public int maxHealth;
    public float playerSpeed;
    public int startLives;
}