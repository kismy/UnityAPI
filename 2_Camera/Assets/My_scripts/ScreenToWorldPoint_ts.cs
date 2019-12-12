using UnityEngine;
using System.Collections;

public class ScreenToWorldPoint_ts : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 1.0f);
        camera.fieldOfView = 60.0f;
        camera.aspect = 16.0f / 10.0f;
        //Z轴前方100处对应的屏幕的左下角的世界坐标值
        Debug.Log("1:" + camera.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 100.0f)));
        //Z轴前方100处对应的屏幕的中间的世界坐标值
        Debug.Log("2:" + camera.ScreenToWorldPoint(new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 100.0f)));
        //Z轴前方100处对应的屏幕的右上角的世界坐标值
        Debug.Log("3:" + camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 100.0f)));
    }
}
