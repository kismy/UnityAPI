using UnityEngine;
using System.Collections;

public class FromToRotation_ts : MonoBehaviour
{
    public Transform A, B, C, D;
    Quaternion q1 = Quaternion.identity;

    void Update()
    {
        //ʹ��ʵ������
        //����ֱ��ʹ��C.rotation.SetFromToRotation(A.position,B.position);
        q1.SetFromToRotation(A.position, B.position);
        C.rotation = q1;
        //ʹ���෽��
        D.rotation = Quaternion.FromToRotation(A.position, B.position);
        //��Scene��ͼ�л���ֱ��
        Debug.DrawLine(Vector3.zero, A.position, Color.white);
        Debug.DrawLine(Vector3.zero, B.position, Color.white);
        Debug.DrawLine(C.position, C.position + new Vector3(0.0f, 1.0f, 0.0f), Color.white);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.up * 1.5f), Color.white);
        Debug.DrawLine(D.position, D.position + new Vector3(0.0f, 1.0f, 0.0f), Color.white);
        Debug.DrawLine(D.position, D.TransformPoint(Vector3.up * 1.5f), Color.white);
    }
}
