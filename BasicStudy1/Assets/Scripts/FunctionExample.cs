using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    void SayHello()
    {
        Debug.Log("hello unity");
    }
    int Sum(int a , int b)
    {
        return a + b;
    }
    void Start()
    {
        SayHello();
        Debug.Log(Sum(4,4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
