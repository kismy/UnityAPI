using UnityEngine;
using System.Collections;

public class ClosestPowerOfTwo_ts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("11与8最接近，输出值为：" + Mathf.ClosestPowerOfTwo(11));
        Debug.Log("12与8和16的差值都为4，输出值为：" + Mathf.ClosestPowerOfTwo(12));
        Debug.Log("当value<0时，输出值为：" + Mathf.ClosestPowerOfTwo(-1));
    }
}
