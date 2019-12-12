using UnityEngine;
using System.Collections;

public class ScreenToWorldPoint_ts : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 1.0f);
        camera.fieldOfView = 60.0f;
        camera.aspect = 16.0f / 10.0f;
        //Z��ǰ��100����Ӧ����Ļ�����½ǵ���������ֵ
        Debug.Log("1:" + camera.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 100.0f)));
        //Z��ǰ��100����Ӧ����Ļ���м����������ֵ
        Debug.Log("2:" + camera.ScreenToWorldPoint(new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 100.0f)));
        //Z��ǰ��100����Ӧ����Ļ�����Ͻǵ���������ֵ
        Debug.Log("3:" + camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 100.0f)));
    }
}
