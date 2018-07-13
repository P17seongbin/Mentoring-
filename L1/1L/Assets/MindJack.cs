using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindJack : MonoBehaviour
{
    GameObject Obj;
    public float del;
    float accel_x, accel_y, accel_z;
    float grav;
    // Use this for initialization
    void Start()
    {
        Obj = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Obj.transform.Translate(0, 0, del);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Obj.transform.Translate(0, 0, -1 * del);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
        {
            Obj.transform.Translate(del, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
        {
            Obj.transform.Translate(-1 * del, 0, 0);
        }
        //할거 없으면 점프 기능도 만들어봅시다(버그 있음)
        if (Input.GetKey(KeyCode.Space))
        {
            grav = 0.3f;
            Obj.transform.Translate(0, grav, 0);
        }
        grav = Mathf.Min(0.0f, grav -= del);
    }
}
