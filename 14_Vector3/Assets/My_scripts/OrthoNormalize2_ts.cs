using UnityEngine;
using System.Collections;

public class OrthoNormalize2_ts : MonoBehaviour {
    public Transform one_T, two_T, three_T;
    Vector3 one_v, two_v, three_v;
    Vector3 one_l, two_l, three_l;

    void Start()
    {
        //初始化起始位置
        one_v = one_T.position;
        two_v = two_T.position;
        three_v = three_T.position;
        //保持初始值
        one_l = one_v;
        two_l = two_v;
        three_l = three_v;
    }

    void Update()
    {
        Vector3.OrthoNormalize(ref one_v, ref two_v,ref three_v);
        //绘制原始向量和OrthoNormalize处理后的向量
        Debug.DrawLine(Vector3.zero, one_l, Color.black);
        Debug.DrawLine(Vector3.zero, two_l, Color.white);
        Debug.DrawLine(Vector3.zero, three_l, Color.green);
        Debug.DrawLine(Vector3.zero, one_v, Color.red);
        Debug.DrawLine(Vector3.zero, two_v, Color.yellow);
        Debug.DrawLine(Vector3.zero, three_v, Color.blue);
    }
}
