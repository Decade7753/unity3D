using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11Excreise : MonoBehaviour
{
    public Transform objA;
    private Vector3 v3;
    private Quaternion q1;
    private Quaternion q2;
    private float time = 0;
    //思路无非就是得向量 再去赋值
    // Start is called before the first frame update
    void Start()
    {
        q1 = this.transform.rotation;
        q2 = Quaternion.LookRotation(objA.position - this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Quaternion.LookRotation(objA.position - this.transform.position) != q2)
        {
            time = 0;
            q2 = Quaternion.LookRotation(objA.position - this.transform.position);
            q1 = this.transform.rotation;
        }
        time += Time.deltaTime;
        v3 = objA.position - this.transform.position;
        //Quaternion.LookRotation(v3);
        this.transform.rotation = Quaternion.Slerp(q1,q2,time);

    }
}
