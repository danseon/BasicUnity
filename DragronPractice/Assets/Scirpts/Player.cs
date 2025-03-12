using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    void Start()
    {

    }


    void Update()
    {
        moveControl();
    }

    void moveControl()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(distanceX, 0, 0);
    }
}
