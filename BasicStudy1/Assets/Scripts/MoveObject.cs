using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5.0f;

    

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);

        //transform.position += move * speed * Time.deltaTime;
        transform.Translate(move * speed * Time.deltaTime);
    }
}
