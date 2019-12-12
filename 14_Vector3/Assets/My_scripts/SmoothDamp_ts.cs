using UnityEngine;
using System.Collections;

public class SmoothDamp_ts : MonoBehaviour {
    public Transform from_T, to_T;
    public float smoothTime, maxSpeed,delta_time;
    Vector3 to_v;
    Vector3 speed = Vector3.zero;

    void Start()
    {
        //��ʼ����ʼλ��
        transform.position = from_T.position;
        to_v = to_T.position;
        //��ʼ��ϵ��
        smoothTime = 1.5f;
        maxSpeed = 10.0f;
        delta_time = 1.0f;
    }

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, to_v, ref speed, smoothTime, maxSpeed, Time.deltaTime * delta_time);
    }
}
