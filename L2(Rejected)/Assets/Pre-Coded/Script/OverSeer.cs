using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverSeer : MonoBehaviour {
    
    public enum block_type { Block_I, Block_O, Block_T, Block_S, Block_Z, Block_J, Block_L, Block_D, Block_Blank}; // D for domino
    public GameObject Block_Prefab;
    List<List<GameObject>> Block_Cache = new List<List<GameObject>>();
    List<List<int>> Block_State = new List<List<int>>();
    bool Inited;
	// Use this for initialization
	void Start () {
        Inited = false;
        List<int> temp = new List<int>();

        for(int i=0;i<10;i++)
        {

        }
            for (int j = 0; j < 17; j++)
            {
        }
        Inited = true;
    }
	
    public void OnClick_Init()
    {
        GameObject.Find("Lettice").GetComponent<OverSeer>().Object_Pooling();
    }
    public void OnClick_Start()
    {
        
    }














    public void Object_Pooling()
    {
        if (!Inited)
        {
            for (int i = 0; i < 10; i++)
            {
                List<int> temp_field = new List<int>();
                List<GameObject> temp_list = new List<GameObject>();
                for (int j = 0; j < 17; j++)
                {
                    temp_field.Add(0);
                    GameObject temp = Instantiate(Block_Prefab);
                    temp.transform.SetParent(transform);
                    temp.transform.localPosition = new Vector3(-8.2f + 1.83f * i, 13.5f - 1.7f * j, -90);
                    temp_list.Add(temp);
                }
                Block_Cache.Add(temp_list);
                Block_State.Add(temp_field);
            }
            Inited = true;
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
