using UnityEngine;
using System.Collections;

public class ClampMagnitude_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 A = new Vector2(10.0f, 20.0f);
        //K值大于1时返回A的初始值
        float b = A.magnitude * 3.0f;
        Vector2 C = Vector2.ClampMagnitude(A, b);
        Debug.Log("K值大于1时返回A的初始值:" + C.ToString());
        //K值小于-1时返回A的初始值
        b = -A.magnitude * 3.0f;
        C = Vector2.ClampMagnitude(A, b);
        Debug.Log("K值小于-1时返回A的初始值:" + C.ToString());
        //K值介于-1和1之间时时按算法求值
        b = A.magnitude * 0.7f;
        C = Vector2.ClampMagnitude(A, b);
        Debug.Log("K值介于-1和1之间时时按算法求值:" + C.ToString());
        //当A为零向量时返回值永远为零向量
        A.Set(0.0f,0.0f);
        b = A.magnitude * 0.7f;
        C = Vector2.ClampMagnitude(A, b);
        Debug.Log("当A为零向量时返回值永远为零向量:" + C.ToString());
    }
}
