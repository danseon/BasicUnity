using UnityEngine;

public class LoopExample : MonoBehaviour
{

    void Start()
    {
        // for (int i = 0; i<10; i++)
        // {
        //     Debug.Log(i);
        // }

        int counter =0;
        while(counter <5)
        {
            Debug.Log("while Count : " + counter);
            counter++;
        }

    }

    void Update()
    {
        
    }
}
