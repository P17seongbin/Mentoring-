using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Change : MonoBehaviour
{

    public Text Errorlog;
    public GameObject Overseer;
    //특정 오브젝트를 삭제하는 스크립트
    public void OnClick()
    {
        Overseer.GetComponent<Change>().ColorShift();
    }


    public void ColorShift()
    {
        try
        {
            GameObject target;
            Color rndColor = new Color(Random.value, Random.value, Random.value);

            ///여기 위는 건드리지 마세요 ////////////////////////////////////////////////////////////////////////////////////

            // target에 필드에 나와있는 오브젝트를 할당하는 코드를 작성해보세요(tag를 활용해서 오브젝트를 찾아보세요)

            // 적절한 할당 코드를 작성하면 아래의 주석을 해제해보세요.
             //target.GetComponent<SpriteRenderer>().color = rndColor; return;

            /// 여기 아래도 건드리지 마세요 ////////////////////////////////////////////////////////////////////////////////////
            Errorlog.text = "No target Detected";
        }
        catch
        {
            Errorlog.text = "Assign Error!";
        }
    }
}
