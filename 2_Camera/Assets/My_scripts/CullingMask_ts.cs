using UnityEngine;
using System.Collections;

public class CullingMask_ts : MonoBehaviour
{
    void OnGUI()
    {
        //默认CullingMask=-1，即渲染任何层
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "CullingMask=-1"))
        {
            camera.cullingMask = -1;
        }
        //不渲染任何层
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "CullingMask=0"))
        {
            camera.cullingMask = 0;
        }
        //仅渲染第0层
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "CullingMask=1<<0"))
        {
            camera.cullingMask = 1 << 0;
        }
        //仅渲染第8层
        if (GUI.Button(new Rect(10.0f, 160.0f, 200.0f, 45.0f), "CullingMask=1<<8"))
        {
            camera.cullingMask = 1 << 8;
        }
        //渲染第8层与第0层
        if (GUI.Button(new Rect(10.0f, 210.0f, 200.0f, 45.0f), "CullingMask=0&&8"))
        {
            //注：不可大意写成camera.cullingMask = 1 << 8+1;或
            //camera.cullingMask = 1+1<<8 ;因为根据运算符优先次序其分别等价于：
            //camera.cullingMask = 1 << (8+1)和camera.cullingMask = (1+1)<<8;
            camera.cullingMask = (1 << 8) + 1;
        }

    }
}