using UnityEngine;
using System.Collections;

public class SendMessageUpward_ts : MonoBehaviour {
	void Start () {
        gameObject.SendMessageUpwards("GetChildrenMessage", gameObject.name + ":use SendMessageUpwards send!");
	}
    private void GetParentMessage(string str)
    {
        Debug.Log(gameObject.name + "�յ����෢�͵���Ϣ��" + str);
    }

    private void GetSelfMessage(string str)
    {
        Debug.Log(gameObject.name + "�յ������͵���Ϣ��" + str);
    }

    private void GetChildrenMessage(string str)
    {
        Debug.Log(gameObject.name + "�յ����෢�͵���Ϣ��" + str);
    }
}
