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

        //匀速的变换
        // this.transform.right表示该对象的轴向位置 不是一个标准点
        print(this.transform.right);
       t.position = Vector3.Slerp(this.transform.right * 10, -this.transform.right * 10 + Vector3.up * 0.1f, time * 0.01f);
    }
}
