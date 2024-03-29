using UnityEngine;
using System.Collections;

public class LookRotation_ts : MonoBehaviour
{
    public Transform A, B, C, D;
    Quaternion q1 = Quaternion.identity;

    void Update()
    {
        //使用实例方法
        //不可直接使用C.rotation.SetLookRotation(A.position,B.position);
        q1.SetLookRotation(A.position, B.position);
        C.rotation = q1;
        //使用类方法
        D.rotation = Quaternion.LookRotation(A.position, B.position);
        //绘制直线，请在Scene视图中查看
        Debug.DrawLine(Vector3.zero, A.position, Color.white);
        Debug.DrawLine(Vector3.zero, B.position, Color.white);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.up * 2.5f), Color.white);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.forward * 2.5f), Color.white);
        Debug.DrawLine(D.position, D.TransformPoint(Vector3.up * 2.5f), Color.white);
        Debug.DrawLine(D.position, D.TransformPoint(Vector3.forward * 2.5f), Color.white);
    }
}
