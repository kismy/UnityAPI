using UnityEngine;
using System.Collections;

public class Scale_ts : MonoBehaviour
{
    void Start()
    {
        Vector3 v1 = new Vector3(1.0f, 2.0f, 3.0f);
        Vector3 v2 = new Vector3(4.0f, 5.0f, 6.0f);
        //ʹ��v1.Scale(v2)��ʹ����v1������v2���з������޷���ֵ
        v1.Scale(v2);
        Debug.Log("ʹ��v1.Scale(v2)��v1��ֵ��" + v1.ToString());
        Debug.Log("ʹ��v1.Scale(v2)��v2��ֵ��" + v2.ToString());
        //����v1
        v1.Set(1.0f, 2.0f, 3.0f);
        //ʹ��v3 = Vector3.Scale(v1, v2)���᷵������v1������v2���з����������v3
        //v1��v2����ı�
        Vector3 v3 = Vector3.Scale(v1, v2);
        Debug.Log("ʹ��v3=Vector3.Scale(v1,v2)��v1��ֵ��" + v1.ToString());
        Debug.Log("ʹ��v3=Vector3.Scale(v1,v2)��v2��ֵ��" + v2.ToString());
        Debug.Log("ʹ��v3=Vector3.Scale(v1,v2)��v3��ֵ��" + v3.ToString());
    }
}
