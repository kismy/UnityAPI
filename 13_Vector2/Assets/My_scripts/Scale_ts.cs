using UnityEngine;
using System.Collections;

public class Scale_ts : MonoBehaviour
{
    void Start()
    {
        Vector2 v2 = new Vector2(1.0f, 2.0f);
        //ʵ��������ı�ԭʼ����v2��ֵ���޷���ֵ
        v2.Scale(new Vector2(2.0f, 3.0f));
        Debug.Log("ʹ��ʵ������v2.Scale��v2ֵ��" + v2);

        //ʹ��Set��������v2
        v2.Set(1.0f, 2.0f);
        //�෽������ı�ԭʼ������ֵ���䷵��ֵΪ�����������
        Vector2 v3 = Vector2.Scale(v2, new Vector2(4.0f, 6.0f));
        Debug.Log("ʹ���෽��Vector2.Scale��v2ֵ��" + v2);
        Debug.Log("ʹ���෽��Vector2.Scale��v3ֵ��" + v3);
    }
}
