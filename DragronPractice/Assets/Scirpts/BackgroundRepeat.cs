using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    public const float scrollSpeed = 1f; //스크롤 스피드
    //쿼터의 머터리얼을 저장할 객체 선언
    private Material thisMaterial;
    void Start()
    {
        thisMaterial = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        Vector2 newoffset = thisMaterial.mainTextureOffset;
        newoffset.Set(0,newoffset.y + (scrollSpeed * Time.deltaTime));
        thisMaterial.mainTextureOffset = newoffset;
    }
}
