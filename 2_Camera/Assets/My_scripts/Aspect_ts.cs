using UnityEngine;
using System.Collections;

public class Aspect_ts : MonoBehaviour
{
    void Start()
    {
        //camera.aspect��Ĭ��ֵ��Ϊ��ǰӲ����aspectֵ
        Debug.Log("camera.aspect��Ĭ��ֵ��" + camera.aspect);
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "aspect=1.0f"))
        {
            camera.ResetAspect();
            camera.aspect = 1.0f;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "aspect=2.0f"))
        {
            camera.ResetAspect();
            camera.aspect = 2.0f;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "aspect��ԭĬ��ֵ"))
        {
            camera.ResetAspect();
        }
    }
}
