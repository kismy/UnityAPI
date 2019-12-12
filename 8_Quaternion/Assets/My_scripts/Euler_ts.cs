using UnityEngine;
using System.Collections;

public class Euler_ts : MonoBehaviour
{
    //记录欧拉角，单位为角度，可以在Inspector面板中设置
    public float ex, ey, ez;
    //用于记录计算结果
    float qx, qy, qz, qw;
    float PIover180 = 0.0174532925f;//常量
    Quaternion Q = Quaternion.identity;
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 100.0f, 45.0f), "计算"))
        {
            Debug.Log("欧拉角：" + " ex：" + ex + "  ey：" + ey + "  ez：" + ez);
            //调用方法计算
            Q = Quaternion.Euler(ex, ey, ez);
            Debug.Log("Q.x:" + Q.x + " Q.y:" + Q.y + " Q.z:" + Q.z + " Q.w:" + Q.w);
            //测试算法
            ex = ex * PIover180 / 2.0f;
            ey = ey * PIover180 / 2.0f;
            ez = ez * PIover180 / 2.0f;
            qx = Mathf.Sin(ex) * Mathf.Cos(ey) * Mathf.Cos(ez) + Mathf.Cos(ex) * Mathf.Sin(ey) * Mathf.Sin(ez);
            qy = Mathf.Cos(ex) * Mathf.Sin(ey) * Mathf.Cos(ez) - Mathf.Sin(ex) * Mathf.Cos(ey) * Mathf.Sin(ez);
            qz = Mathf.Cos(ex) * Mathf.Cos(ey) * Mathf.Sin(ez) - Mathf.Sin(ex) * Mathf.Sin(ey) * Mathf.Cos(ez);
            qw = Mathf.Cos(ex) * Mathf.Cos(ey) * Mathf.Cos(ez) + Mathf.Sin(ex) * Mathf.Sin(ey) * Mathf.Sin(ez);
            Debug.Log(" qx:" + qx + " qy:" + qy + " qz:" + qz + " qw:" + qw);
        }
    }
}
