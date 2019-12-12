using UnityEngine;
using System.Collections;

public class CameraToWorldMatrix_ts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Camera旋转前位置：" + transform.position);
        Matrix4x4 m = camera.cameraToWorldMatrix;
        //v3的值为沿着Camera局部坐标系的-z轴方向前移5个单位的位置在世界坐标系中的位置
        Vector3 v3 = m.MultiplyPoint(Vector3.forward * 5.0f);
        //v4的值为沿着Camera世界坐标系的-z轴方向前移5个单位的位置在世界坐标系中的位置
        Vector3 v4 = m.MultiplyPoint(transform.forward * 5.0f);
        //打印v3、v4
        Debug.Log("旋转前，v3坐标值：" + v3);
        Debug.Log("旋转前，v4坐标值：" + v4);
        transform.Rotate(Vector3.up * 90.0f);
        Debug.Log("Camera旋转后位置：" + transform.position);
        m = camera.cameraToWorldMatrix;
        //v3的值为沿着Camera局部坐标系的-z轴方向前移5个单位的位置在世界坐标系中的位置
        v3 = m.MultiplyPoint(Vector3.forward * 5.0f);
        //v3的值为沿着Camera世界坐标系的-z轴方向前移5个单位的位置在世界坐标系中的位置
        v4 = m.MultiplyPoint(transform.forward * 5.0f);
        //打印v3、v4
        Debug.Log("旋转后，v3坐标值：" + v3);
        Debug.Log("旋转后，v4坐标值：" + v4);
    }
}
