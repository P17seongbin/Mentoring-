using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
// 건드리지 마세요!
/// </summary>
public class Create : MonoBehaviour {
    //버튼을 누르면 주어진 prefab에서 새로운 Object를 생성해주고 태그를 달아준다.
    public Text Errorlog;
    public GameObject Overseer;
    public GameObject _prefab;
    //private bool Is_Created;//필드에 이미 오브젝트가 만들어 졌는가?
    public bool Is_Created;//필드에 이미 오브젝트가 만들어 졌는가?
    private void Start()
    {
        Is_Created = false;
    }
    //오브제릴 만드는 스크립트
    public void OnClick()
    {
        Overseer.GetComponent<Create>().Create_New(); //버튼을 누르면 새로운 오브젝트를 생성하는 함수를 호출한다.
    }

    public void Create_New()
    {
        if(Is_Created)//Is_Created라는 bool형 변수의 값을 검사한다
        {
            //Is_Created가 True이다
            Errorlog.text = "A object is already created!";
        }
        else
        {
            //Is_Created가 False이다
            try
            {
                GameObject temp = Instantiate(_prefab);
                Is_Created = true;//true로 바꿔준다 (기존 코드에선 오브젝트를 삭제해도 이 값이 False로 바뀌지 않는다)
            }
            catch
            {
                Errorlog.text = "No prefab has loaded!";
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
