using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myLesson6 : MonoBehaviour
{
    //目标对象的位置信息
    public Transform objPos;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, objPos.position - this.transform.position, Color.red);
        if(Vector3.Dot(this.transform.forward, objPos.position - this.transform.position) > 0)
        {
            Debug.Log("对象在我前方");
        }
        else if(Vector3.Dot(this.transform.forward, objPos.position - this.transform.position) < 0)
        {
            Debug.Log("对象在我后方");
        }
        else
        {
            Debug.Log("对象在我左右两侧");
        }
        //单位向量的情况
        //print("当前目标对象与我的夹角为"+Mathf.Acos(Vector3.Dot(this.transform.forward.normalized,(objPos.position - this.transform.position).normalized)) * Mathf.Rad2Deg);
        //非单位向量情况
        print("当前目标对象与我的夹角为" + Mathf.Acos(Vector3.Dot(this.transform.forward, objPos.position - this.transform.position)/(objPos.position - this.transform.position).magnitude) * Mathf.Rad2Deg);
    }
}
