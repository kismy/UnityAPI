using UnityEngine;
using System.Collections;

public class orthographic_ts : MonoBehaviour
{
    float len = 5.5f;
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 120.0f, 45.0f), "正交投影"))
        {
            camera.orthographic = true;
            len = 5.5f;
        }
        if (GUI.Button(new Rect(150.0f, 10.0f, 120.0f, 45.0f), "透视投影"))
        {
            camera.orthographic = false;
            len = 60.0f;
        }
        if (camera.orthographic)
        {
            //正交投影模式下，物体没有远大近小的效果，
            //orthographicSize的大小无限制，当orthographicSize为负数时视口的内容会颠倒，
            //orthographicSize的绝对值为摄像机视口的高度值，即上下两条边之间的距离
            len = GUI.HorizontalSlider(new Rect(10.0f, 60.0f, 300.0f, 45.0f), len, -20.0f, 20.0f);
            camera.orthographicSize = len;
        }
        else
        {
            //透视投影模式下，物体有远大近小的效果，
            //fieldOfViewd的取值范围为1.0-179.0
            len = GUI.HorizontalSlider(new Rect(10.0f, 60.0f, 300.0f, 45.0f), len, 1.0f, 179.0f);
            camera.fieldOfView = len;
        }
        //实时显示len大小
        GUI.Label(new Rect(320.0f, 60.0f, 120.0f, 45.0f), len.ToString());
    }
}
