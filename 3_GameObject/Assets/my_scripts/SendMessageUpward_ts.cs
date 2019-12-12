using UnityEngine;
using System.Collections;

public class SendMessageUpward_ts : MonoBehaviour {
	void Start () {
        gameObject.SendMessageUpwards("GetChildrenMessage", gameObject.name + ":use SendMessageUpwards send!");
	}
    private void GetParentMessage(string str)
    {
        Debug.Log(gameObject.name + "收到父类发送的消息：" + str);
    }

    private void GetSelfMessage(string str)
    {
        Debug.Log(gameObject.name + "收到自身发送的消息：" + str);
    }

    private void GetChildrenMessage(string str)
    {
        Debug.Log(gameObject.name + "收到子类发送的消息：" + str);
    }
}
