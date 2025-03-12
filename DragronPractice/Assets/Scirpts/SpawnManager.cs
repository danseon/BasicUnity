using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy;
    
    void Start()
    {
        StartCoroutine(SpawnEnemy());        
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1);

        while(true)
        {
            //SpawnEnemy 1 0.5f
            float RandomX = Random.Range(-2f,2f);
            Instantiate(Enemy, new Vector3(RandomX,transform.position.y,0), Quaternion.identity);

            yield return new WaitForSeconds(0.5f); //0.5초마다 생성
        }
    }

    
    void Update()
    {
        
    }
}
