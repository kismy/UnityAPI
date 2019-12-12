using UnityEngine;
using System.Collections;

public class Normalize_ts : MonoBehaviour {
    void Start()
    {
        Vector2 v1 = new Vector2(1.0f, 2.0f);
        //使用属性不改变原始值，有返回值
        Vector2 v2 = v1.normalized;
        Debug.Log("使用属性v2.normalized后v1的值：" + v1);
        Debug.Log("使用属性v2.normalized后的返回值v2：" + v2);

        v1.Set(1.0f, 2.0f);
        //使用实例方法改变原始值，无返回值
        v1.Normalize();
        Debug.Log("使用实例方法v1.Normalize后v1的值：" + v1);
    }
}
