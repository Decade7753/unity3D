using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myLesson6_1 : MonoBehaviour
{
    //目标对象的位置信息
    public Transform objPos;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, objPos.position - this.transform.position, Color.red);
    }
}
