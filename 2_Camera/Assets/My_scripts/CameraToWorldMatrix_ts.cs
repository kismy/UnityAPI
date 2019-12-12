using UnityEngine;
using System.Collections;

public class CameraToWorldMatrix_ts : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Camera��תǰλ�ã�" + transform.position);
        Matrix4x4 m = camera.cameraToWorldMatrix;
        //v3��ֵΪ����Camera�ֲ�����ϵ��-z�᷽��ǰ��5����λ��λ������������ϵ�е�λ��
        Vector3 v3 = m.MultiplyPoint(Vector3.forward * 5.0f);
        //v4��ֵΪ����Camera��������ϵ��-z�᷽��ǰ��5����λ��λ������������ϵ�е�λ��
        Vector3 v4 = m.MultiplyPoint(transform.forward * 5.0f);
        //��ӡv3��v4
        Debug.Log("��תǰ��v3����ֵ��" + v3);
        Debug.Log("��תǰ��v4����ֵ��" + v4);
        transform.Rotate(Vector3.up * 90.0f);
        Debug.Log("Camera��ת��λ�ã�" + transform.position);
        m = camera.cameraToWorldMatrix;
        //v3��ֵΪ����Camera�ֲ�����ϵ��-z�᷽��ǰ��5����λ��λ������������ϵ�е�λ��
        v3 = m.MultiplyPoint(Vector3.forward * 5.0f);
        //v3��ֵΪ����Camera��������ϵ��-z�᷽��ǰ��5����λ��λ������������ϵ�е�λ��
        v4 = m.MultiplyPoint(transform.forward * 5.0f);
        //��ӡv3��v4
        Debug.Log("��ת��v3����ֵ��" + v3);
        Debug.Log("��ת��v4����ֵ��" + v4);
    }
}
