using UnityEngine;
using System.Collections;

public class WorldToCameraMatrix_ts : MonoBehaviour
{
    public Camera c_test;
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "���ı任����"))
        {
            //ʹ��c_test�ı任����
            camera.worldToCameraMatrix = c_test.worldToCameraMatrix;
            //Ҳ��ʹ�����´���ʵ��ͬ������
            // camera.CopyFrom(c_test);
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "���ñ任����"))
        {
            camera.ResetWorldToCameraMatrix();
        }
    }
}
