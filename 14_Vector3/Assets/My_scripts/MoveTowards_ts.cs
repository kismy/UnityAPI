using UnityEngine;
using System.Collections;

public class MoveTowards_ts : MonoBehaviour {
    public Transform from_T, to_T;
    Vector3 from_v, to_v;
    Vector3 moves = Vector3.zero;
    float speed = 0.5f;

    void Start()
    {
        //��ʼ����ʼλ��
        from_v = from_T.position;
        to_v = to_T.position;
    }

    void Update()
    {
        //��������ֵto_v-from_v��ģ��ʱ����moves��from_v�ƶ���to_v
       moves = Vector3.MoveTowards(from_v, to_v, Time.time * speed);
        //���ƴ�ԭ�㵽slerps�ĺ��ߣ�������100���Ա�۲�
        //����ʱֻ����scene��ͼ�в鿴
        Debug.DrawLine(Vector3.zero, moves, Color.red, 100.0f);
    }
}

