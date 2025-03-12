using UnityEngine;

public class Singleton : MonoBehaviour
{
    // 하나의 인스턴스만 유지하면서 어디서든 접근 가능하게 만든다.
    public static Singleton Instance { get; private set; }
    private void Awake() //함수 한번 실행하는건데 start보다 더 빠르게 실행되는 함수
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //씬이 바뀌어도 유지되게하는 함수
        }
        else
        {
            Destroy(gameObject); //중복 생성 방지
        }
    }

    public void PrintMessage()
    {
        Debug.Log("싱글톤 메시지 출력");
    }
    void Update()
    {

    }
}
