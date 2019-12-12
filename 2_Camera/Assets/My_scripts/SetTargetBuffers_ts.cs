using UnityEngine;
using System.Collections;

public class SetTargetBuffers_ts : MonoBehaviour
{
    //声明两个RendererTexture变量
    public RenderTexture RT_1, RT_2;
    public Camera c;//指定Camera

    void OnGUI()
    {
        //设置RT_1的buffer为摄像机c的渲染
        if (GUI.Button(new Rect(10.0f, 10.0f, 180.0f, 45.0f), "set target buffers"))
        {
            c.SetTargetBuffers(RT_1.colorBuffer, RT_1.depthBuffer);
        }
        //设置RT_2的buffer为摄像机c的渲染，此时RT_1的buffer变为场景中Camera1的渲染
        if (GUI.Button(new Rect(10.0f, 60.0f, 180.0f, 45.0f), "Reset target buffers"))
        {
            c.SetTargetBuffers(RT_2.colorBuffer, RT_2.depthBuffer);
        }
    }
}
