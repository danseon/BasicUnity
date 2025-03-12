using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    
    void Update()
    {
        float movex = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float movey = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        if (Input.GetAxis("Horizontal") <= -0.1f) //left
            ani.SetBool("left",true);
        else
            ani.SetBool("left",false);
        
        if(Input.GetAxis("Horizontal") >= 0.1f) //right
            ani.SetBool("right",true);
        else
            ani.SetBool("right",false);

        if(Input.GetAxis("Vertical") >= 0.1f) //foward
            ani.SetBool("up",true);
        else
            ani.SetBool("up",false);

        if (Input.GetKey(KeyCode.Space))
        {
            moveSpeed = 10.0f;
        }
        else
        {
            moveSpeed = 5f;
        }
        transform.Translate(movex, movey, 0);
    }
}
