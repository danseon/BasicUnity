using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //움직일 속도를 지정해 줍니다.
    public float moveSpeed = 1.5f;
    public GameObject enemybullet;

    void Start()
    {
        InvokeRepeating("Shoot",0.5f,1f);
    }


    void Update()
    {
        //움직일 거리를 계산 해줍니다.
        float distanceY = moveSpeed * Time.deltaTime;

        //움직임 반영
        transform.Translate(0, -distanceY, 0);
    }

    //화면 밖으로 나가서 카메라에 보이지 않으면 호출
    private void OnBecameInvisible()
    {
        Destroy(gameObject); //객체를 삭제한다.
        CancelInvoke("Shoot");
    }
    
    void Shoot()
    {
        Instantiate(enemybullet,transform.position, Quaternion.identity);
    }
}
