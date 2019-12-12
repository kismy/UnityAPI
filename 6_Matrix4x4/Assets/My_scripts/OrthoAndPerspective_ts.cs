using UnityEngine;
using System.Collections;

public class OrthoAndPerspective_ts : MonoBehaviour
{
    Matrix4x4 Perspective = Matrix4x4.identity;//透视投影变量
    Matrix4x4 ortho = Matrix4x4.identity;//正交投影变量
    //声明变量，用于记录正交视口的左、右、下、上的值
    float l, r, b, t;
    void Start()
    {
        //设置透视投影矩阵
        Perspective = Matrix4x4.Perspective(65.0f, 1.5f, 0.1f, 500.0f);
        t = 10.0f;
        b = -t;
        //为防止视图变形需要与 Camera.main.aspect相乘
        l = b * Camera.main.aspect;
        r = t * Camera.main.aspect;
        //设置正交投影矩阵
        ortho = Matrix4x4.Ortho(l, r, b, t, 0.1f, 100.0f);
    }

    void OnGUI()
    {
        //使用默认正交投影
        if (GUI.Button(new Rect(10.0f, 8.0f, 150.0f, 20.0f), "Reset Ortho"))
        {
            Camera.main.orthographic = true;
            Camera.main.ResetProjectionMatrix();
            Camera.main.orthographicSize = 5.1f;
        }
        //使用自定义正交投影
        if (GUI.Button(new Rect(10.0f, 38.0f, 150.0f, 20.0f), "use Ortho"))
        {
            ortho = Matrix4x4.Ortho(l, r, b, t, 0.1f, 100.0f);
            Camera.main.orthographic = true;
            Camera.main.ResetProjectionMatrix();
            Camera.main.projectionMatrix = ortho;
            Camera.main.orthographicSize = 5.1f;
        }
        //使用自定义透视投影
        if (GUI.Button(new Rect(10.0f, 68.0f, 150.0f, 20.0f), "use Perspective"))
        {
            Camera.main.orthographic = false;
            Camera.main.projectionMatrix = Perspective;
        }
        //恢复系统默认透视投影
        if (GUI.Button(new Rect(10.0f, 98.0f, 150.0f, 20.0f), "Reset  Perspective"))
        {
            Camera.main.orthographic = false;
            Camera.main.ResetProjectionMatrix();
        }
    }
}
