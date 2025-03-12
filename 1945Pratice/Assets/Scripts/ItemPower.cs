using UnityEngine;

public class ItemPower : MonoBehaviour
{
    public float itemSpeed = 100f;
    Rigidbody2D rig = null;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(itemSpeed, itemSpeed, 0f));
    }

    
    void Update()
    {
        
    }
}
