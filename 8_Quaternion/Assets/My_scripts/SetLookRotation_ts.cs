using UnityEngine;
using System.Collections;

public class SetLookRotation_ts : MonoBehaviour
{
    public Transform A, B, C;
    Quaternion q1 = Quaternion.identity;

    void Update()
    {
        //����ֱ��ʹ��C.rotation.SetLookRotation(A.position,B.position);
        q1.SetLookRotation(A.position, B.position);
        C.rotation = q1;
        //�ֱ����A��B��C.right�ĳ�����
        //����Scene��ͼ�в鿴
        Debug.DrawLine(Vector3.zero, A.position, Color.red);
        Debug.DrawLine(Vector3.zero, B.position, Color.green);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.right * 2.5f), Color.yellow);
        Debug.DrawLine(C.position, C.TransformPoint(Vector3.forward * 2.5f), Color.black);
        //�ֱ��ӡC.right��A��B�ļн�
        Debug.Log("C.right��A�ļн�:" + Vector3.Angle(C.right, A.position));
        Debug.Log("C.right��B�ļн�:" + Vector3.Angle(C.right, B.position));
        //C.up��B�ļн�
        Debug.Log("C.up��B�ļн�:" + Vector3.Angle(C.up, B.position));
    }
}

