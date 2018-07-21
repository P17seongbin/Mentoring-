using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{

    public Text Errorlog; //Scene에 이미 있는 에러 로그(UI Text)를 가리키는 변수
    public GameObject Overseer; //자기 자신(GameObject)를 저장하는 변수
    //특정 오브젝트를 삭제하는 스크립트
    //버튼이 눌렸을 때 실행될 함수. 주의해야 할 점은 이 함수는 오브젝트 독립적이기 때문에 특정 오브젝트에 붙은 Script의 함수를 실행하려면 아래와 같이 간접적으로 실행해야 한다.
    public void OnClick()
    {
        Overseer.GetComponent<Change>().ColorShift();
    }
    public void ColorShift()
    {
        try //에러가 생기면 아래의 catch절로 간다
        {
            GameObject target; //찾은 GameObject를 저장할 변수
            Color rndColor = new Color(Random.value, Random.value, Random.value); //색깔

            ///여기 위는 건드리지 마세요 ////////////////////////////////////////////////////////////////////////////////////
            target = GameObject.FindWithTag("Square");
            // target에 필드에 나와있는 오브젝트를 할당하는 코드를 작성해보세요(tag를 활용해서 오브젝트를 찾아보세요)

            // 적절한 할당 코드를 작성하면 아래의 주석을 해제해보세요.
            target.GetComponent<SpriteRenderer>().color = rndColor; return;

            /// 여기 아래도 건드리지 마세요 ////////////////////////////////////////////////////////////////////////////////////
            Errorlog.text = "No target Detected";//가짜 에러 로그의 텍스트를 변경한다.
        }
        catch //에러 생김
        {
            Errorlog.text = "Assign Error!"; //가짜 에러 로그의 텍스트를 변경한다.
        }
    }
}
