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
    /// 1.��yֵ���ж����� ����������ж�����
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
        //        print("�������Ϸ�");
        //    }
        //    else
        //    {
        //        print("�������·�");
        //    }
        //}
        //else if (C.y < 0)
        //{
        //    if (Obj.position.y > this.transform.position.y)
        //    {
        //        print("�������Ϸ�");
        //    }
        //    else
        //    {
        //        print("�������·�");
        //    }

        //}
        #endregion
        #region 2
        distance = Vector3.Distance(this.transform.position , Obj.position);
        //�õ�Ŀ��������ĽǶ�
        angle = Mathf.Acos(Vector3.Dot(this.transform.forward, (Obj.position - this.transform.position).normalized)) * Mathf.Rad2Deg;

        //���ұ�
        if(Vector3.Cross(this.transform.forward , Obj.position - this.transform.position).y > 0)
        {
            if (angle <= 30 && distance <= 5)
            {
                print("����������");
            }
        }
        //�����
        else
        {
            if (angle <= 20 && distance <= 5)
            {
                print("����������");
            }
        }
        #endregion

    }
}
