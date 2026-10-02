using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInfoSO", menuName = "Scriptable Objects/PlayerInfoSO")]
public class PlayerInfoSO : ScriptableObject
{
    public string playerName;
    public int score;
    public float health;
    public int lives;
}
