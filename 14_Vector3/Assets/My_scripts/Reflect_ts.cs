using UnityEngine;
using System.Collections;

public class Reflect_ts : MonoBehaviour
{
    public Transform A, B;
    //A_vΪ����������B_vΪ��������
    Vector3 A_v, B_v;
    //R_vΪ��������
    Vector3 R_v = Vector3.zero;

    void Update()
    {
        //�������������е�λ������������������һ��Ϊ���淴��
        A_v = A.position.normalized;
        B_v = B.position;
        R_v = Vector3.Reflect(B_v, A_v);

        Debug.DrawLine(-A_v * 1.5f, A_v *1.5f, Color.black);
        Debug.DrawLine(Vector3.zero, B_v, Color.yellow);
        Debug.DrawLine(Vector3.zero, R_v, Color.red);
    }
}
