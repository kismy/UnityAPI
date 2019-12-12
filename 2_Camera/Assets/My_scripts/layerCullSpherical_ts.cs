using UnityEngine;
using System.Collections;

public class layerCullSpherical_ts : MonoBehaviour
{
    public Transform cb1, cb2, cb3;
    void Start()
    {
        //定义大小为32的一维数组，用来存储所有层的剔除距离
        float[] distances = new float[32];
        //设置第9层的剔除距离
        distances[8] = Vector3.Distance(transform.position, cb1.position);
        //将数组赋给摄像机的layerCullDistances
        camera.layerCullDistances = distances;
        //打印出三个物体距离摄像机的距离
        Debug.Log("Cube1距离摄像机的距离：" + Vector3.Distance(transform.position, cb1.position));
        Debug.Log("Cube2距离摄像机的距离：" + Vector3.Distance(transform.position, cb2.position));
        Debug.Log("Cube3距离摄像机的距离：" + Vector3.Distance(transform.position, cb3.position));
    }

    void OnGUI()
    {
        //使用球形距离剔除
        if (GUI.Button(new Rect(10.0f, 10.0f, 180.0f, 45.0f), "use layerCullSpherical"))
        {
            camera.layerCullSpherical = true;
        }
        //取消球形距离剔除
        if (GUI.Button(new Rect(10.0f, 60.0f, 180.0f, 45.0f), "unuse layerCullSpherical"))
        {
            camera.layerCullSpherical = false;
        }
    }
}
