using UnityEngine;
using System.Collections;

public class GameObjectAndComponent_ts : MonoBehaviour {
    public GameObject sp;
	void Start () {
        //�������ֱ�﷽ʽ����һ���������ص�ǰ�ű�����GameObject�����е�Rigidbody���
        Rigidbody rb1 = rigidbody;
        Rigidbody rb2 = GetComponent<Rigidbody>();
        Rigidbody rb3 = rigidbody.GetComponent<Rigidbody>();
        Debug.Log("rb1��InstanceID��" + rb1.GetInstanceID());
        Debug.Log("rb2��InstanceID��" + rb2.GetInstanceID());
        Debug.Log("rb3��InstanceID��" + rb3.GetInstanceID());

        //ʹ��ǰ�����û�ȡ���ö����Rigidbody���
        Debug.Log("ǰ������sp������Rigidbody��InstanceID��"+sp.GetComponent<Rigidbody>().GetInstanceID());
	}
}
