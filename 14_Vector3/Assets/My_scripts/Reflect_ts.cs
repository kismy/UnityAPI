using UnityEngine;
using System.Collections;

public class Reflect_ts : MonoBehaviour
{
    public Transform A, B;
    //A_v为镜面向量，B_v为入射向量
    Vector3 A_v, B_v;
    //R_v为反射向量
    Vector3 R_v = Vector3.zero;

    void Update()
    {
        //将镜面向量进行单位化处理，否则反射向量不一定为镜面反射
        A_v = A.position.normalized;
        B_v = B.position;
        R_v = Vector3.Reflect(B_v, A_v);

        Debug.DrawLine(-A_v * 1.5f, A_v *1.5f, Color.black);
        Debug.DrawLine(Vector3.zero, B_v, Color.yellow);
        Debug.DrawLine(Vector3.zero, R_v, Color.red);
    }
}
