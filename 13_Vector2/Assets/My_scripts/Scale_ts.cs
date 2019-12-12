using UnityEngine;
using System.Collections;

public class Scale_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 v2 = new Vector2(1.0f, 2.0f);
        //实例方法会改变原始向量v2的值，无返回值
        v2.Scale(new Vector2(2.0f, 3.0f));
        Debug.Log("使用实例方法v2.Scale后v2值：" + v2);

        //使用Set方法重设v2
        v2.Set(1.0f, 2.0f);
        //类方法不会改变原始向量的值，其返回值为放缩后的向量
        Vector2 v3 = Vector2.Scale(v2, new Vector2(4.0f, 6.0f));
        Debug.Log("使用类方法Vector2.Scale后v2值：" + v2);
        Debug.Log("使用类方法Vector2.Scale后v3值：" + v3);
    }
}
