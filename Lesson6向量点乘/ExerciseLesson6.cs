using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseLesson6 : MonoBehaviour
{
    //1.对象间的位置可以用向量模长或distacne求
    //2.直接用被依附对象的forward与ob向量进行点乘 反向求出角度如果小于22.5就符合条件!
    // Start is called before the first frame update

    public Transform objPos;
    private float distacne;
    private float angle;
    void Update()
    {
        //先看距离
        distacne = Vector3.Distance(this.transform.position , objPos.position);
        //再看角度
        angle = Mathf.Acos(Vector3.Dot(this.transform.forward , (objPos.position - this.transform.position).normalized)) * Mathf.Rad2Deg;

        if (distacne <=5 && angle <= 22.5)
        {
            print("发现敌人!");
        }
        Debug.DrawRay(this.transform.position , objPos.position - this.transform.position);
    }
}
