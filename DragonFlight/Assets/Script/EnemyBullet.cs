using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public GameObject explosion;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
    }
    private void OnBecameInvisible() //카메라에 렌더링 되지 않을 때
    {
        Destroy(gameObject); //대문자는 게임오브젝트 클래스, 소문자는 this.gameObject
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪혔다
        if (collision.gameObject.CompareTag("Player"))
        {
            //폭발 이펙트 생성
            Instantiate(explosion, transform.position, Quaternion.identity);
            //SoundManager에서 싱글톤사용 함수호출 사운드재생
            SoundManager.instance.SoundDie();
            Destroy(collision.gameObject);
            //자기 자신
            Destroy(gameObject);
        }
    }
}