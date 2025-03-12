using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject bullet; //미사일 프리팹 가져올 변수
    
    void Start()
    {
        //InvokeRepeating(함수이름,초기지연시간,지연할시간)
        InvokeRepeating("Shoot",0.5f,0.5f);
    }
    void Shoot()
    {
        //미시일 프리팹, 런처 포지션, 방향값 안줌
        Instantiate(bullet,transform.position,Quaternion.identity);

        //SoundManager에서 싱글톤사용 함수호출
        SoundManager.instance.PlayBulletSound();
    }
   
    void Update()
    {
        
    }
}
