using UnityEngine;
using System.Collections;
public class LayerCullDistances_ts : MonoBehaviour
{
    public Transform cb1;
    void Start()
    {
        //定义大小为32的一维数组，用来存储所有层的剔除距离
        float[] distances = new float[32];
        //设置第9层的剔除距离
        distances[8] = Vector3.Distance(transform.position, cb1.position);
        //将数组赋给摄像机的layerCullDistances
        camera.layerCullDistances = distances;
    }
    void Update()
    {
        //摄像机远离物体
        transform.Translate(transform.right * Time.deltaTime);
    }
}