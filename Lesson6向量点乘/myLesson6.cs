using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myLesson6 : MonoBehaviour
{
    //Ŀ������λ����Ϣ
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
            Debug.Log("��������ǰ��");
        }
        else if(Vector3.Dot(this.transform.forward, objPos.position - this.transform.position) < 0)
        {
            Debug.Log("�������Һ�");
        }
        else
        {
            Debug.Log("����������������");
        }
        //��λ���������
        //print("��ǰĿ��������ҵļн�Ϊ"+Mathf.Acos(Vector3.Dot(this.transform.forward.normalized,(objPos.position - this.transform.position).normalized)) * Mathf.Rad2Deg);
        //�ǵ�λ�������
        print("��ǰĿ��������ҵļн�Ϊ" + Mathf.Acos(Vector3.Dot(this.transform.forward, objPos.position - this.transform.position)/(objPos.position - this.transform.position).magnitude) * Mathf.Rad2Deg);
    }
}
