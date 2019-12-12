using UnityEngine;
using System.Collections;

public class MoveTowards_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 A = new Vector2(10.0f, 20.0f);
        Vector2 B = new Vector2(30.0f, 40.0f);
        //当K=1时返回B的值
        float sp = (B - A).magnitude;
        Vector2 C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("当K=1时返回B的值:" + C.ToString());
        //当K>1时返回B的值
        sp += 10.0f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("当K>1时返回B的值:" + C.ToString());
        //当K=0时返回A的值
        sp = 0.0f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("当K=0时返回A的值:" + C.ToString());
        //当K<0时按算法计算
        sp = -10.0f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("当K<0时按算法计算:" + C.ToString());
        //当K>0且K<1时按算法计算
        sp = (B - A).magnitude * 0.7f;
        C = Vector2.MoveTowards(A, B, sp);
        Debug.Log("当K>0且K<1时按算法计算:" + C.ToString());
    }
}
