using UnityEngine;
using System.Collections;

public class ViewportToWorldPoint_ts : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(1.0f, 0.0f, 1.0f);
        camera.fieldOfView = 60.0f;
        camera.aspect = 16.0f / 10.0f;
        //��Ļ���½�
        Debug.Log("1:" + camera.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, 100.0f)));
        //��Ļ�м�
        Debug.Log("2:" + camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 100.0f)));
        //��Ļ���Ͻ�
        Debug.Log("3:" + camera.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, 100.0f)));
    }
}
