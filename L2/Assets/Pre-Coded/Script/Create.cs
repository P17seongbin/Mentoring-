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
    private bool Is_Created;//필드에 이미 오브제가 만들어 졌는가?
    private void Start()
    {
        Is_Created = false;
    }
    //오브제릴 만드는 스크립트
    public void OnClick()
    {
        Overseer.GetComponent<Create>().Create_New();
    }

    public void Create_New()
    {
        if(Is_Created)
        {
            Errorlog.text = "A object is already created!";
        }
        else
        {
            try
            {
                GameObject temp = Instantiate(_prefab);
                Is_Created = true;
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
