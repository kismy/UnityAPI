using UnityEngine;
using System.Collections;

public class ScreenToViewportPoint_ts : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 1.0f);
        transform.rotation = Quaternion.identity;
        //从屏幕的实际坐标点向视口的单位化比例值转换
        Debug.Log("1:" + camera.ScreenToViewportPoint(new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 100.0f)));
        //从视口的单位化比例值向屏幕的实际坐标点转换
        Debug.Log("2:" + camera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f, 100.0f)));
        Debug.Log("屏幕宽：" + Screen.width + "  屏幕高：" + Screen.height);
    }
}
