using UnityEngine;
using System.Collections;

public class ClampMagnitude_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 A = new Vector2(10.0f, 20.0f);
        //Kֵ����1ʱ����A�ĳ�ʼֵ
        float b = A.magnitude * 3.0f;
        Vector2 C = Vector2.ClampMagnitude(A, b);
        Debug.Log("Kֵ����1ʱ����A�ĳ�ʼֵ:" + C.ToString());
        //KֵС��-1ʱ����A�ĳ�ʼֵ
        b = -A.magnitude * 3.0f;
        C = Vector2.ClampMagnitude(A, b);
        Debug.Log("KֵС��-1ʱ����A�ĳ�ʼֵ:" + C.ToString());
        //Kֵ����-1��1֮��ʱʱ���㷨��ֵ
        b = A.magnitude * 0.7f;
        C = Vector2.ClampMagnitude(A, b);
        Debug.Log("Kֵ����-1��1֮��ʱʱ���㷨��ֵ:" + C.ToString());
        //��AΪ������ʱ����ֵ��ԶΪ������
        A.Set(0.0f,0.0f);
        b = A.magnitude * 0.7f;
        C = Vector2.ClampMagnitude(A, b);
        Debug.Log("��AΪ������ʱ����ֵ��ԶΪ������:" + C.ToString());
    }
}
