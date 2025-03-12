using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    Animator ani; //애니메이터 변수
    private Vector2 minBounds;
    private Vector2 maxBounds;
    void Start()
    {
       
        ani = GetComponent<Animator>();
    }


    void Update()
    {
        //방향키에 따른 움직임
        float movex = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float movey = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        //aniamtion component
           //min -1 0 max 1
        if(Input.GetAxis("Horizontal") <= -0.1f)
            ani.SetBool("left", true);
        else
            ani.SetBool("left",false); //left motion

        if(Input.GetAxis("Horizontal") >= 0.1f)
            ani.SetBool("right", true);
        else
            ani.SetBool("right",false); //right motion

        if (Input.GetAxis("Vertical") >= 0.1f)
            ani.SetBool("up",true);
        else 
            ani.SetBool("up", false); //up motion

         transform.Translate(movex, movey, 0);
    }
}
