using UnityEngine;
using System.Collections;

public class RenderWithShader_ts : MonoBehaviour
{
    bool is_use = false;
    void OnGUI()
    {
        if (is_use)
        {
            //ʹ�ø߹�shader��Specular����ȾCamera
            camera.RenderWithShader(Shader.Find("Specular"), "RenderType");
        }
        if (GUI.Button(new Rect(10.0f, 10.0f, 300.0f, 45.0f), "ʹ��RenderWithShader���ø߹�"))
        {
            //RenderWithShaderÿ����һ��ֻ��Ⱦһ֡�����Բ��ɽ���ֱ�ӷŵ����
            //camera.RenderWithShader(Shader.Find("Specular"), "RenderType");
            is_use = true;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 300.0f, 45.0f), "ʹ��SetReplacementShader���ø߹�"))
        {
            //SetReplacementShader���������滻����shader������һ�μ���
            camera.SetReplacementShader(Shader.Find("Specular"), "RenderType");
            is_use = false;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 300.0f, 45.0f), "�رո߹�"))
        {
            camera.ResetReplacementShader();
            is_use = false;
        }
    }
}
