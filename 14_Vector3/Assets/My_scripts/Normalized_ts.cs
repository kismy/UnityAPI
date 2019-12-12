using UnityEngine;
using System.Collections;

public class Normalized_ts : MonoBehaviour
{
    void Start()
    {
        Vector3 v1 = new Vector3(1.0f, 2.0f, 3.0f);
        Vector3 v2 = v1.normalized;
        //使用v2 = v1.normalized后v1的值不会改变，而v2的值为v1的单位向量。
        Debug.Log("v2 = v1.normalized后v1的值：" + v1);
        Debug.Log("v2 = v1.normalized后v2的值：" + v2);
        //"v2 = Vector3.Normalize(v1)"与"v2 = v1.normalized"实现功能相同，但不常用。
        v2 = Vector3.Normalize(v1);
        Debug.Log("v2 = Vector3.Normalize(v1)后v1的值：" + v1);
        Debug.Log("v2 = Vector3.Normalize(v1)后v2的值：" + v2);
        //v1.Normalize()等于将v1自身进行了单位化处理，v1变成了新的向量。
        v1.Normalize();
        Debug.Log("v1.Normalize()后v1的值：" + v1);
    }
}
