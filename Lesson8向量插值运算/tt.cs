using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class tt : MonoBehaviour
{
    public float time = 0;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        //���ٵı任
        // this.transform.right��ʾ�ö��������λ�� ����һ����׼��
        print(this.transform.right);
       t.position = Vector3.Slerp(this.transform.right * 10, -this.transform.right * 10 + Vector3.up * 0.1f, time * 0.01f);
    }
}
