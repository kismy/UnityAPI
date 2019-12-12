using UnityEngine;
using System.Collections;

public class Lerp_ts : MonoBehaviour
{
    public Transform start_T;//��ʼ��λ������
    public Transform end_T;//������λ������
    Vector3 start_v, end_v;//��ʼ�ͽ���������Vector3
    float speed = 0.2f;//�����ƶ��ٶ�
    float last_time;//���Ʋ�ֵϵ����Χ
    void Start()
    {
        start_v = start_T.position;
        end_v = end_T.position;
        last_time = Time.time;
    }
    void Update()
    {
        //���ò�ֵ�ı�����λ������ﵽ�˶�Ŀ��
        transform.position = Vector3.Lerp(start_v, end_v, (Time.time - last_time) * speed);
        if (transform.position == end_v)
        {
            //�Ե���ʼ�ͽ���������
            transform.position = start_v;
            start_v = end_v;
            end_v = transform.position;
            transform.position = start_v;
            last_time = Time.time;
        }
    }
}
