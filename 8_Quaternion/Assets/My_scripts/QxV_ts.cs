using UnityEngine;
using System.Collections;

public class QxV_ts : MonoBehaviour
{
    public Transform A;
    float speed = 0.1f;
    //��ʼ��A��position��eulerAngles
    void Start()
    {
        A.position = Vector3.zero;
        A.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);
    }

    void Update()
    {
        //����A����������ϵ��forward����ÿ֡ǰ��speed����
        A.position += A.rotation * (Vector3.forward * speed);
        Debug.Log(A.position);
    }
}