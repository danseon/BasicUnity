using Unity.Mathematics;
using UnityEngine;
using System.Collections;

public class launcher : MonoBehaviour
{
    public GameObject Bullet;
    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }

    IEnumerator ShootCoroutine()
    {
        yield return new WaitForSeconds(0.5f);

        while (true)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(0.6f);
        }
    }
}

