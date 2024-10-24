using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����һ����ǰ�����ӵ����͵ı���
public enum E_bullet_Type
{
    //����
    single,
    //˫��
    doubleBullet,
    //����
    sector,
    //����
    annular,


}
public class Player : MonoBehaviour
{
    //�ӵ�Ԥ����
    public GameObject bullet;
    //����һ��ö�ٱ����������
    public E_bullet_Type nowWeaponType = E_bullet_Type.single;
    //��¼��ǰ�Ƕ�
    private float angle = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��Ұ�Qʱ�л�����
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
                //forѭ���������ǶȺͿ�����������
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
