using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //몬스터 가지고 오기
    public GameObject Enemy;
    //적을 생성하는 함수
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f); //적이 나타날 x좌표 생성

        //적을 생성한다.
        Instantiate(Enemy,new Vector3(randomX,transform.position.y,0f),Quaternion.identity);
    }
    void Start()
    {
        //SpawnEnemy 1 0.5f
        InvokeRepeating("SpawnEnemy", 1.0f, 0.5f);
    }


    void Update()
    {

    }
}
