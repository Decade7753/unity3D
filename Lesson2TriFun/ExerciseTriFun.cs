using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseTriFun : MonoBehaviour
{
    //�ƶ��ٶ�
    public float moveSpeed = 5;
    //ʵ������ �����尴�����Һ����������Һ����ƶ�
    private float time = 0f;
    //���Һ������ƶ�������
    public float changeMaxMin = 0.5f;
    //��������
    public float period = 0.1f;



    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //���ñ������Ķ������泯���ƶ�
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //�����������ƶ� ��ΪSin�����ķ���ֵ��������������Կ���ʵ���ƶ������ת��
        //����time�ǻ��� ���̫��ᵼ�º��������ں����
        time += Time.deltaTime * period;
        this.transform.Translate(Vector3.right * changeMaxMin * Time.deltaTime * Mathf.Sin(time));

    }
}
