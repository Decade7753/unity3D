using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseLesson8 : MonoBehaviour
{
    public Transform Obj;
    private float distance;
    private float angle;
    #region 1
    /// <summary>
    /// 1.用y值来判断上下 用向量叉乘判断左右
    /// </summary>
    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 1
        //Vector3 C = Vector3.Cross(this.transform.forward, Obj.position - this.transform.position);
        //if (C.y > 0)
        //{
        //    if (Obj.position.y > this.transform.position.y)
        //    {
        //        print("在我右上方");
        //    }
        //    else
        //    {
        //        print("在我右下方");
        //    }
        //}
        //else if (C.y < 0)
        //{
        //    if (Obj.position.y > this.transform.position.y)
        //    {
        //        print("在我左上方");
        //    }
        //    else
        //    {
        //        print("在我左下方");
        //    }

        //}
        #endregion
        #region 2
        distance = Vector3.Distance(this.transform.position , Obj.position);
        //得到目标正方向的角度
        angle = Mathf.Acos(Vector3.Dot(this.transform.forward, (Obj.position - this.transform.position).normalized)) * Mathf.Rad2Deg;

        //在右边
        if(Vector3.Cross(this.transform.forward , Obj.position - this.transform.position).y > 0)
        {
            if (angle <= 30 && distance <= 5)
            {
                print("发现入侵者");
            }
        }
        //在左边
        else
        {
            if (angle <= 20 && distance <= 5)
            {
                print("发现入侵者");
            }
        }
        #endregion

    }
}
