using UnityEngine;
using System.Collections;

public class SendMessage_ts : MonoBehaviour {
	void Start () {
        //�����༰�Լ�������Ϣ
		//gameObject.BroadcastMessage("GetParentMessage",gameObject.name+":use BroadcastMessage send!");
        //���Լ�������Ϣ
		gameObject.SendMessage("GetSelfMessage",gameObject.name+":use SendMessage send!");
        ////���༰�Լ�������Ϣ
		//gameObject.SendMessageUpwards("GetChildrenMessage",gameObject.name+":use SendMessageUpwards send!");
	}
	//һ�����ܸ��෢����Ϣ�ķ���
	private void GetParentMessage(string str){
        Debug.Log(gameObject.name + "�յ����෢�͵���Ϣ��" + str);
	}
    //һ��������������Ϣ�ķ���
    private void GetSelfMessage(string str)
    {
        Debug.Log(gameObject.name + "�յ������͵���Ϣ��" + str);
	}
    //һ���������෢����Ϣ�ķ���
    private void GetChildrenMessage(string str)
    {
        Debug.Log(gameObject.name + "�յ����෢�͵���Ϣ��" + str);
	}
}
