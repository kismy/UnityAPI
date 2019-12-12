using UnityEngine;
using System.Collections;

public class RotateTowards_ts : MonoBehaviour
{
    public Transform from_T, to_T;
    Vector3 from_v, to_v;
    Vector3 rotates = Vector3.zero;
    float speed = 0.2f;
    float l;

    void Start()
    {
        //初始化起始位置
        from_v = from_T.position;
        to_v = to_T.position;
        //l取值为0时，rotates会以from_v的模长运动到to_v方向
       // l = 0.0f;
        //l取值为(to_v - from_v).sqrMagnitude时，rotates会以to_v的模长运动到to_v方向
        l = (to_v - from_v).sqrMagnitude;
    }

    void Update()
    {
        //在1/speed时间内rotates从from_v移动到to_v
        rotates = Vector3.RotateTowards(from_v, to_v, Time.time*speed,l);
        //绘制从原点到slerps的红线，并保留100秒以便观察
        //运行时只能在scene视图中查看
        Debug.DrawLine(Vector3.zero, rotates, Color.red, 100.0f);
    }
}
