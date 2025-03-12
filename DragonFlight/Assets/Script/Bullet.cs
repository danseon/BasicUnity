using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 2f;
    public GameObject exposion;
    void Start()
    {

    }

    void Update()
    {
        //y축 이동
        transform.Translate(0,moveSpeed * Time.deltaTime,0);
    }

    private void OnBecameInvisible() //카메라에 렌더링 되지 않을 때
    {
        Destroy(gameObject); //대문자는 게임오브젝트 클래스, 소문자는 this.gameObject
    }

    //2D 충돌 트리거 이벤트
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪혔다
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //폭발 이펙트 생성
            Instantiate(exposion, transform.position, Quaternion.identity);
            //SoundManager에서 싱글톤사용 함수호출 사운드재생
            SoundManager.instance.SoundDie();
            //점수 올려주기
            GameManager.instance.AddScore(10);
            //Enemy태그가 붙은 콜리전의 게임오브젝트 파괴 (적)
            Destroy(collision.gameObject);
            //자기 자신
            Destroy(gameObject);
        }
    }
}
