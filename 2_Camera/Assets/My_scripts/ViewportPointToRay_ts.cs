using UnityEngine;
using System.Collections;

public class ViewportPointToRay_ts : MonoBehaviour
{
    Ray ray;//����
    RaycastHit hit;
    Vector3 v3 = new Vector3(0.5f, 0.5f, 0.0f);
    Vector3 hitpoint = Vector3.zero;
    void Update()
    {
        //����������ĻX���������ѭ��ɨ��
        v3.x = v3.x >= 1.0f ? 0.0f : v3.x + 0.002f;
        //��������
        ray = camera.ViewportPointToRay(v3);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            //�����ߣ���Scene��ͼ�пɼ�
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            //�������̽�⵽�����������
            Debug.Log("����̽�⵽���������ƣ�" + hit.transform.name);
        }
    }
}
