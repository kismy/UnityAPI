using UnityEngine;
using System.Collections;

public class SendMessage_ts : MonoBehaviour {
	void Start () {
        //向子类及自己发送信息
		//gameObject.BroadcastMessage("GetParentMessage",gameObject.name+":use BroadcastMessage send!");
        //向自己发送信息
		gameObject.SendMessage("GetSelfMessage",gameObject.name+":use SendMessage send!");
        ////向父类及自己发送信息
		//gameObject.SendMessageUpwards("GetChildrenMessage",gameObject.name+":use SendMessageUpwards send!");
	}
	//一个接受父类发送信息的方法
	private void GetParentMessage(string str){
        Debug.Log(gameObject.name + "收到父类发送的消息：" + str);
	}
    //一个接受自身发送信息的方法
    private void GetSelfMessage(string str)
    {
        Debug.Log(gameObject.name + "收到自身发送的消息：" + str);
	}
    //一个接受子类发送信息的方法
    private void GetChildrenMessage(string str)
    {
        Debug.Log(gameObject.name + "收到子类发送的消息：" + str);
	}
}
