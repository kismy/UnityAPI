using UnityEngine;
using System.Collections;

public class NewScene2_ts : MonoBehaviour
{
    GameObject cube, plane;
    void Start()
    {
        Debug.Log("这是NewScene2！");
    }
    //当程序退出时用DestroyImmediate()销毁被HideFlags.DontSave标识的对象,
    //否则即使程序已经退出，被HideFlags.DontSave标识的对象依然在Hierarchy面板中，
    //即每运行一次程序就会产生多余对象，造成内存泄漏。
    void OnApplicationQuit()
    {
        cube = GameObject.Find("Cube0");
        plane = GameObject.Find("Plane");
        if (cube)
        {
            Debug.Log("Cube0 DestroyImmediate");
            DestroyImmediate(cube);
        }
        if (plane)
        {
            Debug.Log("Plane DestroyImmediate");
            DestroyImmediate(plane);
        }
    }
}
