using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N : MonoBehaviour
{
    public Transform obj;
    private Vector3 v3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v3 = this.transform.position;
        Debug.DrawRay(this.transform.position, obj.position - this.transform.position , Color.red);
        v3.z = obj.position.z;
        this.transform.position = v3;
    }
}
