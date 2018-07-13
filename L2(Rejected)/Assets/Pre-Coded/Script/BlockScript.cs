using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : OverSeer {

    List<Color> Block_Color = new List<Color>();
    private GameObject Block_Object;
    private SpriteRenderer Block_Sprite;
	// Use this for initialization
	void Start () {
        Block_Object = gameObject;
        Block_Sprite = Block_Object.GetComponent<SpriteRenderer>();
        Block_Color.Add(Color.cyan);
        Block_Color.Add(Color.yellow);
        Block_Color.Add(Color.magenta);
        Block_Color.Add(Color.green);
        Block_Color.Add(Color.red);
        Block_Color.Add(Color.blue);
        Block_Color.Add(new Color(1f, (164f / 255f), (11f / 255f)));//orange color
        Block_Color.Add(Color.white);
        Block_Color.Add(new Color(1f, 1f, 1f,0.1f));
        Deter_Type(block_type.Block_Blank);
    }
	
    public void Turnonoff(bool Is_On)
    {
        Block_Sprite.enabled = Is_On;
    }

    public void Deter_Type(block_type type)
    {
        Block_Sprite.color = Block_Color[(int)type];
    }
    
	// Update is called once per frame
	void Update () {
		
	}
}
