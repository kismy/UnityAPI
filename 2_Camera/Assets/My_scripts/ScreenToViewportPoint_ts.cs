using UnityEngine;
using System.Collections;

public class ScreenToViewportPoint_ts : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 1.0f);
        transform.rotation = Quaternion.identity;
        //����Ļ��ʵ����������ӿڵĵ�λ������ֵת��
        Debug.Log("1:" + camera.ScreenToViewportPoint(new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 100.0f)));
        //���ӿڵĵ�λ������ֵ����Ļ��ʵ�������ת��
        Debug.Log("2:" + camera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f, 100.0f)));
        Debug.Log("��Ļ��" + Screen.width + "  ��Ļ�ߣ�" + Screen.height);
    }
}
