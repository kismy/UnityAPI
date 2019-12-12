using UnityEngine;
using System.Collections;

public class QxV_ts : MonoBehaviour
{
    public Transform A;
    float speed = 0.1f;
    //初始化A的position和eulerAngles
    void Start()
    {
        A.position = Vector3.zero;
        A.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);
    }

    void Update()
    {
        //沿着A的自身坐标系的forward方向每帧前进speed距离
        A.position += A.rotation * (Vector3.forward * speed);
        Debug.Log(A.position);
    }
}