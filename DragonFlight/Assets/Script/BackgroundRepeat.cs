using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    public float scrollSpeed = 1.2f; //스크롤 속도
    //쿼드의 머터리얼 데이터를 받아올 객체 선언
    private Material thisMaterial;
    void Start()
    {
        //객체가 생성될 때 최초 1회 호출
        //현재 객체의 Component들을 참조해 Renderer라는 컴포넌트의 material 정보 받기

        thisMaterial = GetComponent<Renderer>().material;

    }

   
    void Update()
    {
        //새롭게 지정해줄 offset 객체 선언
        Vector2 newoffset = thisMaterial.mainTextureOffset;
        //y부분에 현재 y값에 속도에 프레임 보정해서 더해줍니다.
        newoffset.Set(0,newoffset.y + (scrollSpeed*Time.deltaTime));
        //최종적으로 offSet qusrud
        thisMaterial.mainTextureOffset = newoffset;
    }
}
