using NUnit.Framework;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore = 0;
    public float Speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;
    void Start()
    {
        //변수 선언
        Debug.Log($"Player Name : {playerName}");
        Debug.Log($"Speed : {Speed}");
        Debug.Log($"Player Score : {playerScore}");
        Debug.Log($"Is Game Over? : {isGameOver}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
