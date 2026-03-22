using UnityEngine;

// Dòng [System.Serializable] này CỰC KỲ QUAN TRỌNG. 
// Nó cho phép Unity biết là: "Ê, hãy biến cái class này thành chuỗi JSON được nhé!"
[System.Serializable] 
public class PlayerData
{
    public int level;
    public int score;
    public string playerName;
}