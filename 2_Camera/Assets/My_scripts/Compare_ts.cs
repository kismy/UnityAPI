using UnityEngine;
using System.Collections;

public class Compare_ts : MonoBehaviour
{
    Vector3 v1;
    void Start()
    {
        v1 = transform.position;
    }
    void OnGUI()
    {
        //设置Camera视口宽高比例为2:1，点击此按钮后更改Game视图中不同的aspect值，
        //尽管Scene视图中Camera视口的宽高比会跟着改变，但实际Camera视口的内容依然是按照2:1
        //的比例所所获取的，不同的屏幕显示相同的内容会发生变形。
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "Camera视口宽高比例2:1"))
        {
            camera.aspect = 2.0f;
            transform.position = v1;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "Camera视口宽高比例1:2"))
        {
            camera.aspect = 0.5f;
            //更改Camera坐标，使被拉伸后的物体显示出来
            transform.position = new Vector3(v1.x, v1.y, 333.2f);
        }
        //恢复aspect的默认设置，即屏幕比例和Camera视口比例保持一致
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "使用Game面板中aspect的选择"))
        {
            camera.ResetAspect();
            transform.position = v1;
        }
    }
}