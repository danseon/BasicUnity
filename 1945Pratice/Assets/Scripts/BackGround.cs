using UnityEngine;

public class BackGround : MonoBehaviour
{
    //배경속도
    public float scrollSpeed = 0.1f;
    private Material thisMaterial; // 이 객체의 Renderer 컴포넌트의 material 정보를 저장할 변수
    void Start()
    {
        thisMaterial = GetComponent<Renderer>().material; //material 저장
    }

    
    void Update()
    {
        Vector2 newoffSet = thisMaterial.mainTextureOffset;
        newoffSet.Set(0, newoffSet.y + (scrollSpeed * Time.deltaTime));
        thisMaterial.mainTextureOffset = newoffSet;
    }
}
