using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseLesson5 : MonoBehaviour
{
    // Start is called before the first frame update

    //想要实现跟随得先获取对象的位置信息
    public Transform objPos;

    // Update is called once per frame
    private void LateUpdate()
    {
        //向量与位置的加减法会产生一个新的位置
        this.transform.position = objPos.position - objPos.forward * 4 + objPos.up * 7;
    }
}
