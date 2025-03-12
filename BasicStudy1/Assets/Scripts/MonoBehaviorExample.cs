using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("start : 게임이 시작될 때 호출됩니다.");
    }

    
    void Update()
    {
        Debug.Log("update: 프레임마다 호출됩니다.");
    }

    private void FixedUpdate()
    {
        Debug.Log("물리 연산에 사용됩니다.");
    }

    //컨트롤 쉬프트 M
}
