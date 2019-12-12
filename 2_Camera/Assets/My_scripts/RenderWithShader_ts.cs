using UnityEngine;
using System.Collections;

public class RenderWithShader_ts : MonoBehaviour
{
    bool is_use = false;
    void OnGUI()
    {
        if (is_use)
        {
            //使用高光shader：Specular来渲染Camera
            camera.RenderWithShader(Shader.Find("Specular"), "RenderType");
        }
        if (GUI.Button(new Rect(10.0f, 10.0f, 300.0f, 45.0f), "使用RenderWithShader启用高光"))
        {
            //RenderWithShader每调用一次只渲染一帧，所以不可将其直接放到这儿
            //camera.RenderWithShader(Shader.Find("Specular"), "RenderType");
            is_use = true;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 300.0f, 45.0f), "使用SetReplacementShader启用高光"))
        {
            //SetReplacementShader方法用来替换已有shader，调用一次即可
            camera.SetReplacementShader(Shader.Find("Specular"), "RenderType");
            is_use = false;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 300.0f, 45.0f), "关闭高光"))
        {
            camera.ResetReplacementShader();
            is_use = false;
        }
    }
}
