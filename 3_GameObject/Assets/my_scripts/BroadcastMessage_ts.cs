using UnityEngine;
using System.Collections;

public class BroadcastMessage_ts : MonoBehaviour
{
    void Start()
    {
        gameObject.BroadcastMessage("GetParentMessage", gameObject.name + ":use BroadcastMessage send!");
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
