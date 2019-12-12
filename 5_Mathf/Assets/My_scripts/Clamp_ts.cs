using UnityEngine;
using System.Collections;

public class Clamp_ts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("当value<min时：" + Mathf.Clamp(-1, 0, 10));
        Debug.Log("当min<value<max时：" + Mathf.Clamp(3, 0, 10));
        Debug.Log("当value>max时：" + Mathf.Clamp(11, 0, 10));
        //方法Clamp01的返回值范围为[0,1]
        Debug.Log("当value<0时:" + Mathf.Clamp01(-0.1f));
        Debug.Log("当0<value<1时:" + Mathf.Clamp01(0.5f));
        Debug.Log("当value>1时:" + Mathf.Clamp01(1.1f));
    }
}
