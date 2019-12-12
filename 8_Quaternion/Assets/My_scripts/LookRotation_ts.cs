using UnityEngine;
using System.Collections;

public class LookRotation_ts : MonoBehaviour
{
    public Transform A, B, C, D;
    Quaternion q1 = Quaternion.identity;

    void Update()
    {
        //ʹ��ʵ������
        //����ֱ��ʹ��C.rotation.SetLookRotation(A.position,B.position);
        q1.SetLookRotation(A.position, B.position);
        C.rotation = q1;
        //ʹ���෽��
        D.rotation = Quaternion.LookRotation(A.position, B.position);
        //����ֱ�ߣ�����Scene��ͼ�в鿴
        Debug.DrawLine(Vector3.zero, A.position, Color.white);
        Debug.DrawLine(Vector3.zero, B.position, Color.white);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.up * 2.5f), Color.white);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.forward * 2.5f), Color.white);
        Debug.DrawLine(D.position, D.TransformPoint(Vector3.up * 2.5f), Color.white);
        Debug.DrawLine(D.position, D.TransformPoint(Vector3.forward * 2.5f), Color.white);
    }
}
