using UnityEngine;
using System.IO; // BẮT BUỘC PHẢI CÓ để xài tính năng Đọc/Ghi File

public class FileSaveManager : MonoBehaviour
{
    // Biến để nhớ đường dẫn tới file save
    string savePath;

    void Start()
    {
        // persistentDataPath là chỗ "trú ẩn" an toàn mà Unity xin quyền Windows để lưu file
        savePath = Application.persistentDataPath + "/SaveGame.json";
        
        // In ra để tí nữa bạn biết đường copy paste vào thư mục tìm file
        Debug.Log("Đường dẫn file save của bạn nằm ở: " + savePath);
    }

    // Hàm này gắn vào nút Save
    public void SaveToFile()
    {
        // 1. Nhập thông tin cần lưu
        PlayerData dataToSave = new PlayerData();
        dataToSave.level = 10;
        dataToSave.score = 9999;
        dataToSave.playerName = "Hien";

        // 2. Chuyển thành chuỗi JSON
        string jsonString = JsonUtility.ToJson(dataToSave);

        // 3. GHI RA FILE THẬT TRÊN Ổ CỨNG!
        File.WriteAllText(savePath, jsonString);
        
        Debug.Log("Đã lưu file thành công!");
    }

    // Hàm này gắn vào nút Load
    public void LoadFromFile()
    {
        // Phải kiểm tra xem file có tồn tại không đã, lỡ người chơi chưa save bao giờ thì sao?
        if (File.Exists(savePath))
        {
            // Đọc toàn bộ chữ bên trong file đó
            string loadedJson = File.ReadAllText(savePath);

            // Dịch ngược lại thành dữ liệu game
            PlayerData loadedData = JsonUtility.FromJson<PlayerData>(loadedJson);

            Debug.Log("Load file thành công! Tên: " + loadedData.playerName + " | Điểm: " + loadedData.score);
        }
        else
        {
            Debug.Log("Lỗi: Không tìm thấy file save nào ở đường dẫn " + savePath);
        }
    }
}