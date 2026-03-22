using UnityEngine;

public class JsonManager : MonoBehaviour
{
    // Hàm này sẽ gắn vào nút Save
    public void SaveDataToJSON()
    {
        // 1. Tạo một gói dữ liệu mới và điền thông tin vào
        PlayerData myData = new PlayerData();
        myData.level = 2;
        myData.score = 500;
        myData.playerName = "Hien";

        // 2. Phép thuật xuất hiện: Biến toàn bộ dữ liệu trên thành 1 chuỗi JSON
        string jsonString = JsonUtility.ToJson(myData);

        // 3. In ra Console để giảng viên thấy bạn đã làm thành công
        Debug.Log("Đã đóng gói thành chuỗi JSON: " + jsonString);

        // (Mẹo nhỏ: Mình mượn tạm PlayerPrefs để cất chuỗi chữ này đi)
        PlayerPrefs.SetString("MyJsonSave", jsonString);
        PlayerPrefs.Save();
    }

    // Hàm này sẽ gắn vào nút Load
    public void LoadDataFromJSON()
    {
        // 1. Lấy chuỗi JSON đã cất trong máy ra
        string savedJsonString = PlayerPrefs.GetString("MyJsonSave", "");

        if (savedJsonString != "")
        {
            // 2. Giải nén chuỗi JSON đó ngược lại thành dữ liệu Object
            PlayerData loadedData = JsonUtility.FromJson<PlayerData>(savedJsonString);

            // 3. In ra để kiểm tra
            Debug.Log("Đã Load thành công! Tên: " + loadedData.playerName + " | Level: " + loadedData.level);
        }
        else
        {
            Debug.Log("Chưa có file lưu nào cả!");
        }
    }
}