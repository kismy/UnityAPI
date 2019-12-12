using UnityEngine;
using System.Collections;

public class Slerp_ts : MonoBehaviour {
    public Transform from_T, to_T;
    Vector3 from_v, to_v;
    Vector3 slerps = Vector3.zero;
    float speed = 0.1f;

	void Start () {
        //��ʼ����ʼλ��
        from_v = from_T.position;
        to_v = to_T.position;
	}

	void Update () {
        //��1/speedʱ����slerps��from_v�ƶ���to_v
        slerps = Vector3.Slerp(from_v,to_v,Time.time*speed);
        //���ƴ�ԭ�㵽slerps�ĺ��ߣ�������100���Ա�۲�
        //����ʱֻ����scene��ͼ�в鿴
        Debug.DrawLine(Vector3.zero,slerps,Color.red,100.0f);
	}
}
