using UnityEngine;
using System.Collections;

public class Slerp_ts : MonoBehaviour {
    public Transform from_T, to_T;
    Vector3 from_v, to_v;
    Vector3 slerps = Vector3.zero;
    float speed = 0.1f;

	void Start () {
        //初始化起始位置
        from_v = from_T.position;
        to_v = to_T.position;
	}

	void Update () {
        //在1/speed时间内slerps从from_v移动到to_v
        slerps = Vector3.Slerp(from_v,to_v,Time.time*speed);
        //绘制从原点到slerps的红线，并保留100秒以便观察
        //运行时只能在scene视图中查看
        Debug.DrawLine(Vector3.zero,slerps,Color.red,100.0f);
	}
}
