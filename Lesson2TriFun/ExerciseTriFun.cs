using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseTriFun : MonoBehaviour
{
    //移动速度
    public float moveSpeed = 5;
    //实现内容 让物体按照正弦函数或者余弦函数移动
    private float time = 0f;
    //正弦函数的移动上下限
    public float changeMaxMin = 0.5f;
    //函数周期
    public float period = 0.1f;



    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //先让被依附的对象朝着面朝向移动
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //再让其左右移动 因为Sin函数的返回值会包含负数，所以可以实现移动方向的转换
        //由于time是弧度 如果太快会导致函数的周期很奇怪
        time += Time.deltaTime * period;
        this.transform.Translate(Vector3.right * changeMaxMin * Time.deltaTime * Mathf.Sin(time));

    }
}
