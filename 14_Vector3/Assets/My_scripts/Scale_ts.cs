using UnityEngine;
using System.Collections;

public class Scale_ts : MonoBehaviour
{
    void Start()
    {
        Vector3 v1 = new Vector3(1.0f, 2.0f, 3.0f);
        Vector3 v2 = new Vector3(4.0f, 5.0f, 6.0f);
        //使用v1.Scale(v2)将使向量v1按向量v2进行放缩，无返回值
        v1.Scale(v2);
        Debug.Log("使用v1.Scale(v2)后v1的值：" + v1.ToString());
        Debug.Log("使用v1.Scale(v2)后v2的值：" + v2.ToString());
        //重设v1
        v1.Set(1.0f, 2.0f, 3.0f);
        //使用v3 = Vector3.Scale(v1, v2)将会返回向量v1按向量v2进行放缩后的向量v3
        //v1、v2不会改变
        Vector3 v3 = Vector3.Scale(v1, v2);
        Debug.Log("使用v3=Vector3.Scale(v1,v2)后v1的值：" + v1.ToString());
        Debug.Log("使用v3=Vector3.Scale(v1,v2)后v2的值：" + v2.ToString());
        Debug.Log("使用v3=Vector3.Scale(v1,v2)后v3的值：" + v3.ToString());
    }
}
