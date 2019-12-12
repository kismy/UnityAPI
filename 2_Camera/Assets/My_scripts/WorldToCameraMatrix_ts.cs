using UnityEngine;
using System.Collections;

public class WorldToCameraMatrix_ts : MonoBehaviour
{
    public Camera c_test;
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "更改变换矩阵"))
        {
            //使用c_test的变换矩阵
            camera.worldToCameraMatrix = c_test.worldToCameraMatrix;
            //也可使用如下代码实现同样功能
            // camera.CopyFrom(c_test);
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "重置变换矩阵"))
        {
            camera.ResetWorldToCameraMatrix();
        }
    }
}
