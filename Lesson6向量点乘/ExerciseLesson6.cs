using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseLesson6 : MonoBehaviour
{
    //1.������λ�ÿ���������ģ����distacne��
    //2.ֱ���ñ����������forward��ob�������е�� ��������Ƕ����С��22.5�ͷ�������!
    // Start is called before the first frame update

    public Transform objPos;
    private float distacne;
    private float angle;
    void Update()
    {
        //�ȿ�����
        distacne = Vector3.Distance(this.transform.position , objPos.position);
        //�ٿ��Ƕ�
        angle = Mathf.Acos(Vector3.Dot(this.transform.forward , (objPos.position - this.transform.position).normalized)) * Mathf.Rad2Deg;

        if (distacne <=5 && angle <= 22.5)
        {
            print("���ֵ���!");
        }
        Debug.DrawRay(this.transform.position , objPos.position - this.transform.position);
    }
}
