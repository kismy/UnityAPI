using UnityEngine;
using System.Collections;

public class Aspect_ts : MonoBehaviour
{
    void Start()
    {
        //camera.aspect的默认值即为当前硬件的aspect值
        Debug.Log("camera.aspect的默认值：" + camera.aspect);
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
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "aspect还原默认值"))
        {
            camera.ResetAspect();
        }
    }
}
