using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//定义一个当前发射子弹类型的变量
public enum E_bullet_Type
{
    //单发
    single,
    //双发
    doubleBullet,
    //扇形
    sector,
    //环形
    annular,


}
public class Player : MonoBehaviour
{
    //子弹预设体
    public GameObject bullet;
    //申明一个枚举变量参与计算
    public E_bullet_Type nowWeaponType = E_bullet_Type.single;
    //记录当前角度
    private float angle = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //玩家按Q时切换武器
        if (Input.GetKeyDown(KeyCode.Q))
        {
            nowWeaponType = nowWeaponType + 1;
            if ((int)nowWeaponType > 3) 
            {
                nowWeaponType = E_bullet_Type.single ;
            }
        }

        switch (nowWeaponType)
        {
            case E_bullet_Type.single:
                if (Input.GetMouseButton(0))
                {
                    GameObject o1 = GameObject.Instantiate(bullet, this.transform.position, this.transform.rotation);
                    o1.transform.rotation *= Quaternion.AngleAxis(90, Vector3.up);
                }
                break;
            case E_bullet_Type.doubleBullet:
                //for循环来调整角度和控制生成数量
                if (Input.GetMouseButton(0))
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        GameObject o2 = GameObject.Instantiate(bullet , this.transform.position , this.transform.rotation);
                        o2.transform.rotation *= Quaternion.AngleAxis(i, Vector3.up);
                    }
                }
                    
                    
                break;
            case E_bullet_Type.sector:
                if (Input.GetMouseButton(0))
                {
                    for (int i = 1; i <= 180; i++)
                    {
                        GameObject o3 = GameObject.Instantiate(bullet, this.transform.position, this.transform.rotation);
                        o3.transform.rotation *= Quaternion.AngleAxis(i, Vector3.up);
                    }
                }
                break;
            case E_bullet_Type.annular:
                if (Input.GetMouseButton(0))
                {
                    for (int i = 1; i <= 360; i++)
                    {
                        GameObject o4 = GameObject.Instantiate(bullet, this.transform.position, this.transform.rotation);
                        o4.transform.rotation *= Quaternion.AngleAxis(i, Vector3.up);
                    }
                }
                break;
        }

    }
}
