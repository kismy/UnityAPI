using UnityEngine;
using System.Collections;

public class Normalize_ts : MonoBehaviour {
    void Start()
    {
        Vector2 v1 = new Vector2(1.0f, 2.0f);
        //ʹ�����Բ��ı�ԭʼֵ���з���ֵ
        Vector2 v2 = v1.normalized;
        Debug.Log("ʹ������v2.normalized��v1��ֵ��" + v1);
        Debug.Log("ʹ������v2.normalized��ķ���ֵv2��" + v2);

        v1.Set(1.0f, 2.0f);
        //ʹ��ʵ�������ı�ԭʼֵ���޷���ֵ
        v1.Normalize();
        Debug.Log("ʹ��ʵ������v1.Normalize��v1��ֵ��" + v1);
    }
}
