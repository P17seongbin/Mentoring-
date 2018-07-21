using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Delete : MonoBehaviour {

    public Text Errorlog;
    public GameObject Overseer;
    //특정 오브젝트를 삭제하는 스크립트
    public void OnClick()
    {
        Overseer.GetComponent<Delete>().Remove();
    }


    public void Remove()
    {
        GameObject target;
        try
        {

            ///여기 위는 건드리지 마세요 ////////////////////////////////////////////////////////////////////////////////////

            target = GameObject.Find("Block(Clone)");
            // target에 필드에 나와있는 오브젝트를 할당하는 코드를 작성해보세요(오브젝트의 이름을 활용해서 오브젝트를 찾아보세요)

            GameObject.Find("Create").GetComponent<Create>().Is_Created = false;
            // 적절한 할당 코드를 작성하면 아래의 주석을 해제해보세요.

            target.SetActive(false); return;
            //오브젝트를 삭제해도 Create.cs에 있는 Is_Created라는 bool형 변수의 값이 변하지 않습니다.


            /// 여기 아래도 건드리지 마세요 ////////////////////////////////////////////////////////////////////////////////////
            Errorlog.text = "No target Detected";
        }
        catch
        {
            Errorlog.text = "Assign Error!";
        }
    }


}
