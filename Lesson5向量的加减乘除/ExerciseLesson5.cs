using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseLesson5 : MonoBehaviour
{
    // Start is called before the first frame update

    //��Ҫʵ�ָ�����Ȼ�ȡ�����λ����Ϣ
    public Transform objPos;

    // Update is called once per frame
    private void LateUpdate()
    {
        //������λ�õļӼ��������һ���µ�λ��
        this.transform.position = objPos.position - objPos.forward * 4 + objPos.up * 7;
    }
}
