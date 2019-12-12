using UnityEngine;
using System.Collections;

public class ToAngleAxis_ts : MonoBehaviour
{
    public Transform A, B;
    float angle;
    Vector3 axis = Vector3.zero;

    void Update()
    {
        //使用ToAngleAxis获取A的Rotation的旋转轴和角度
        A.rotation.ToAngleAxis(out angle, out axis);
        //使用AngleAxis设置B的rotation，使得B的rotation状态的和A相同
        //可以在程序运行时修改A的rotation查看B的状态
        B.rotation = Quaternion.AngleAxis(angle, axis);
    }
}
