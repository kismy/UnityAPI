using UnityEngine;
using System.Collections;

public class SetTRS_ts : MonoBehaviour
{
    Vector3 v1 = Vector3.one;
    Vector3 v2 = Vector3.zero;

    void Start()
    {
        Matrix4x4 m1 = Matrix4x4.identity;
        //Position��Y������5����λ����Y����ת45�ȣ�����2��
        m1.SetTRS(Vector3.up * 5, Quaternion.Euler(Vector3.up * 45.0f), Vector3.one * 2.0f);
        //Ҳ����ʹ�����¾�̬��������m1�任
        //m1 = Matrix4x4.TRS(Vector3.up * 5, Quaternion.Euler(Vector3.up * 45.0f), Vector3.one * 2.0f);
        v2 = m1.MultiplyPoint3x4(v1);
        Debug.Log("v1��ֵ��" + v1);
        Debug.Log("v2��ֵ��" + v2);
    }

    void FixedUpdate()
    {
        Debug.DrawLine(Vector3.zero, v1, Color.green);
        Debug.DrawLine(Vector3.zero, v2, Color.red);
    }
}
