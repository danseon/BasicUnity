using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
