using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //提供给外部根据鼠标滚轮来调整摄像机距离
    public float ratespeed = 0;
    public float distance = 0;  
    public float moveSpeed = 5;
    public GameObject targetObj;
    //为了插值计算的中间向量v1
    private Vector3 v1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel")>0f)
        {
            distance += 1;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            distance -= 1;
        }
       
        //死板的跟随
        //this.transform.position = targetObj.transform.position + new Vector3(0, 1, 0) + new Vector3(0, 0, -5);
        //动态 先快后慢的跟随
        this.transform.position = Vector3.Lerp(this.transform.position , targetObj.transform.position + new Vector3(0, 1+distance, 0) + new Vector3(0, 0, -5+distance) , Time.deltaTime *moveSpeed);

        //实现一直看向目标
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation , Quaternion.LookRotation(targetObj.transform.position - this.transform.position) , Time.deltaTime * ratespeed);
    }
}
