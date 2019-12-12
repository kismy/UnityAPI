using UnityEngine;
using System.Collections;

public class SetTRS_ts : MonoBehaviour
{
    Vector3 v1 = Vector3.one;
    Vector3 v2 = Vector3.zero;

    void Start()
    {
        Matrix4x4 m1 = Matrix4x4.identity;
        //Position沿Y轴增加5个单位，绕Y轴旋转45度，放缩2倍
        m1.SetTRS(Vector3.up * 5, Quaternion.Euler(Vector3.up * 45.0f), Vector3.one * 2.0f);
        //也可以使用如下静态方法设置m1变换
        //m1 = Matrix4x4.TRS(Vector3.up * 5, Quaternion.Euler(Vector3.up * 45.0f), Vector3.one * 2.0f);
        v2 = m1.MultiplyPoint3x4(v1);
        Debug.Log("v1的值：" + v1);
        Debug.Log("v2的值：" + v2);
    }

    void FixedUpdate()
    {
        Debug.DrawLine(Vector3.zero, v1, Color.green);
        Debug.DrawLine(Vector3.zero, v2, Color.red);
    }
}
