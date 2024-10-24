using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //�ṩ���ⲿ�������������������������
    public float ratespeed = 0;
    public float distance = 0;  
    public float moveSpeed = 5;
    public GameObject targetObj;
    //Ϊ�˲�ֵ������м�����v1
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
       
        //����ĸ���
        //this.transform.position = targetObj.transform.position + new Vector3(0, 1, 0) + new Vector3(0, 0, -5);
        //��̬ �ȿ�����ĸ���
        this.transform.position = Vector3.Lerp(this.transform.position , targetObj.transform.position + new Vector3(0, 1+distance, 0) + new Vector3(0, 0, -5+distance) , Time.deltaTime *moveSpeed);

        //ʵ��һֱ����Ŀ��
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation , Quaternion.LookRotation(targetObj.transform.position - this.transform.position) , Time.deltaTime * ratespeed);
    }
}
