using UnityEngine;
using System.Collections;

public class Compare_ts : MonoBehaviour
{
    Vector3 v1;
    void Start()
    {
        v1 = transform.position;
    }
    void OnGUI()
    {
        //����Camera�ӿڿ�߱���Ϊ2:1������˰�ť�����Game��ͼ�в�ͬ��aspectֵ��
        //����Scene��ͼ��Camera�ӿڵĿ�߱Ȼ���Ÿı䣬��ʵ��Camera�ӿڵ�������Ȼ�ǰ���2:1
        //�ı���������ȡ�ģ���ͬ����Ļ��ʾ��ͬ�����ݻᷢ�����Ρ�
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "Camera�ӿڿ�߱���2:1"))
        {
            camera.aspect = 2.0f;
            transform.position = v1;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "Camera�ӿڿ�߱���1:2"))
        {
            camera.aspect = 0.5f;
            //����Camera���꣬ʹ��������������ʾ����
            transform.position = new Vector3(v1.x, v1.y, 333.2f);
        }
        //�ָ�aspect��Ĭ�����ã�����Ļ������Camera�ӿڱ�������һ��
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "ʹ��Game�����aspect��ѡ��"))
        {
            camera.ResetAspect();
            transform.position = v1;
        }
    }
}