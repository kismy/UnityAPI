using UnityEngine;
using System.Collections;

public class CullingMask_ts : MonoBehaviour
{
    void OnGUI()
    {
        //Ĭ��CullingMask=-1������Ⱦ�κβ�
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "CullingMask=-1"))
        {
            camera.cullingMask = -1;
        }
        //����Ⱦ�κβ�
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "CullingMask=0"))
        {
            camera.cullingMask = 0;
        }
        //����Ⱦ��0��
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "CullingMask=1<<0"))
        {
            camera.cullingMask = 1 << 0;
        }
        //����Ⱦ��8��
        if (GUI.Button(new Rect(10.0f, 160.0f, 200.0f, 45.0f), "CullingMask=1<<8"))
        {
            camera.cullingMask = 1 << 8;
        }
        //��Ⱦ��8�����0��
        if (GUI.Button(new Rect(10.0f, 210.0f, 200.0f, 45.0f), "CullingMask=0&&8"))
        {
            //ע�����ɴ���д��camera.cullingMask = 1 << 8+1;��
            //camera.cullingMask = 1+1<<8 ;��Ϊ������������ȴ�����ֱ�ȼ��ڣ�
            //camera.cullingMask = 1 << (8+1)��camera.cullingMask = (1+1)<<8;
            camera.cullingMask = (1 << 8) + 1;
        }

    }
}