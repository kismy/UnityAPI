using UnityEngine;
using System.Collections;

public class Lerp_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 v1 = new Vector2(4.0f, 12.0f);
        Vector2 v2 = new Vector2(9.0f, 20.0f);
        //e<0时返回值为v1的值
        Debug.Log("e<0时返回值为v1的值:" + Vector2.Lerp(v1, v2, -2.0f));
        //e>1时返回值为v2的值
        Debug.Log("e>1时返回值为v2的值:" + Vector2.Lerp(v1, v2, 2.0f));
        //e>0且e<1时按插值算法求返回值
        Debug.Log("e>0且e<1时按插值算法求返回值:" + Vector2.Lerp(v1, v2, 0.7f));
    }
}
