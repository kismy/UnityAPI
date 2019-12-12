using UnityEngine;
using System.Collections;

public class ScreenPointToRay_ts : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Vector3 v3 = new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 0.0f);
    Vector3 hitpoint = Vector3.zero;
    void Update()
    {
        //����������ĻX���������ѭ��ɨ��
        v3.x = v3.x >= Screen.width ? 0.0f : v3.x + 1.0f;
        //��������
        ray = camera.ScreenPointToRay(v3);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            //�����ߣ���Scene��ͼ�пɼ�
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            //�������̽�⵽�����������
            Debug.Log("����̽�⵽���������ƣ�" + hit.transform.name);
        }
    }
}
