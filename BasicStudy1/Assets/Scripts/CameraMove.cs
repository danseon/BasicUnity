using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("Sphere");
    }

    
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y+1
        , playerPos.z-3);
    }
}
