using UnityEngine;
using System.Collections;

public class Lerp_ts : MonoBehaviour
{
    public Transform start_T;//起始点位置物体
    public Transform end_T;//结束点位置物体
    Vector3 start_v, end_v;//起始和结束的两个Vector3
    float speed = 0.2f;//控制移动速度
    float last_time;//控制插值系数范围
    void Start()
    {
        start_v = start_T.position;
        end_v = end_T.position;
        last_time = Time.time;
    }
    void Update()
    {
        //利用插值改变物体位置坐标达到运动目的
        transform.position = Vector3.Lerp(start_v, end_v, (Time.time - last_time) * speed);
        if (transform.position == end_v)
        {
            //对调起始和结束点坐标
            transform.position = start_v;
            start_v = end_v;
            end_v = transform.position;
            transform.position = start_v;
            last_time = Time.time;
        }
    }
}
