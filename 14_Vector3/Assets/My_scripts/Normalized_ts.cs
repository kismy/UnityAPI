using UnityEngine;
using System.Collections;

public class Normalized_ts : MonoBehaviour
{
    void Start()
    {
        Vector3 v1 = new Vector3(1.0f, 2.0f, 3.0f);
        Vector3 v2 = v1.normalized;
        //ʹ��v2 = v1.normalized��v1��ֵ����ı䣬��v2��ֵΪv1�ĵ�λ������
        Debug.Log("v2 = v1.normalized��v1��ֵ��" + v1);
        Debug.Log("v2 = v1.normalized��v2��ֵ��" + v2);
        //"v2 = Vector3.Normalize(v1)"��"v2 = v1.normalized"ʵ�ֹ�����ͬ���������á�
        v2 = Vector3.Normalize(v1);
        Debug.Log("v2 = Vector3.Normalize(v1)��v1��ֵ��" + v1);
        Debug.Log("v2 = Vector3.Normalize(v1)��v2��ֵ��" + v2);
        //v1.Normalize()���ڽ�v1��������˵�λ������v1������µ�������
        v1.Normalize();
        Debug.Log("v1.Normalize()��v1��ֵ��" + v1);
    }
}
