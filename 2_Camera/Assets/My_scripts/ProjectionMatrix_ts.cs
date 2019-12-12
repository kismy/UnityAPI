using UnityEngine;
using System.Collections;

public class ProjectionMatrix_ts : MonoBehaviour
{
    public Transform sp, cb;
    public Matrix4x4 originalProjection;
    float q=0.1f;//晃动振幅
    float p=1.5f;//晃动频率
    int which_change = -1;
    void Start()
    {
        //记录原始投影矩阵
        originalProjection = camera.projectionMatrix;
    }
    void Update()
    {
        sp.RotateAround(cb.position, cb.up, 45.0f * Time.deltaTime);
        Matrix4x4 pr = originalProjection;
        switch (which_change)
        {
            case -1:
                break;
            case 0:
                //绕摄像机X轴晃动
                pr.m11 += Mathf.Sin(Time.time * p) * q;
                break;
            case 1:
                //绕摄像机Y轴晃动
                pr.m01 += Mathf.Sin(Time.time * p) * q;
                break;
            case 2:
                //绕摄像机Z轴晃动
                pr.m10 += Mathf.Sin(Time.time * p) * q;
                break;
            case 3:
                //绕摄像机左右移动
                pr.m02 += Mathf.Sin(Time.time * p) * q;
                break;
            case 4:
                //摄像机视口放缩运动
                pr.m00 += Mathf.Sin(Time.time * p) * q;
                break;
        }
        //设置Camera的变换矩阵
        camera.projectionMatrix = pr;
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "绕摄像机X轴晃动"))
        {
            camera.ResetProjectionMatrix();
            which_change = 0;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "绕摄像机Y轴晃动"))
        {
            camera.ResetProjectionMatrix();
            which_change = 1;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "绕摄像机Z轴晃动"))
        {
            camera.ResetProjectionMatrix();
            which_change = 2;
        }
        if (GUI.Button(new Rect(10.0f, 160.0f, 200.0f, 45.0f), "绕摄像机左右移动"))
        {
            camera.ResetProjectionMatrix();
            which_change = 3;
        }
        if (GUI.Button(new Rect(10.0f, 210.0f, 200.0f, 45.0f), "视口放缩运动"))
        {
            camera.ResetProjectionMatrix();
            which_change = 4;
        }
    }
}