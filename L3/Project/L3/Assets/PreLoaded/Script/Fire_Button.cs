using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire_Button : MonoBehaviour {

    Text Button_Text;//버튼의 텍스트를 의미합니다.
    bool Is_Firing;//현재 발사중입니까?
    public void Text_Swap()
    {
        Is_Firing = !Is_Firing;
        if (Is_Firing)
            Button_Text.text = "Stop";
        else
            Button_Text.text = "Fire!";
    }
	// Use this for initialization
	void Start () {
        Is_Firing = false;
        Button_Text = transform.Find("Text").gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
