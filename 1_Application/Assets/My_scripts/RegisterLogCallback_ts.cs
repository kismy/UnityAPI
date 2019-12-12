using UnityEngine;
using System.Collections;

public class RegisterLogCallback_ts : MonoBehaviour
{
    string output = "";//��־�����Ϣ
    string stack = "";//��ջ������Ϣ
    string logType = "";//��־����
    int tp = 0;
    //��ӡ��־��Ϣ
    void Update()
    {
        Debug.Log("stack:" + stack);
        Debug.Log("logType:" + logType);
        Debug.Log("tp:"+(tp++));
        Debug.Log("output:" + output);
    }
    void OnEnable()
    {
        //ע��ί��
        Application.RegisterLogCallback(MyCallback);
    }
    void OnDisable()
    {
        //ȡ��ί��
        Application.RegisterLogCallback(null);
    }
    //ί�з���
    //�������ֿ����Զ��壬�������Ĳ�������Ҫ����Application.LogCallback�еĲ�������
    void MyCallback(string logString, string stackTrace, LogType type)
    {
        output = logString;
        stack = stackTrace;
        logType = type.ToString();
    }
}
