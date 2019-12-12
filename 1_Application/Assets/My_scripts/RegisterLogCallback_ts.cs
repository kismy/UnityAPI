using UnityEngine;
using System.Collections;

public class RegisterLogCallback_ts : MonoBehaviour
{
    string output = "";//日志输出信息
    string stack = "";//堆栈跟踪信息
    string logType = "";//日志类型
    int tp = 0;
    //打印日志信息
    void Update()
    {
        Debug.Log("stack:" + stack);
        Debug.Log("logType:" + logType);
        Debug.Log("tp:"+(tp++));
        Debug.Log("output:" + output);
    }
    void OnEnable()
    {
        //注册委托
        Application.RegisterLogCallback(MyCallback);
    }
    void OnDisable()
    {
        //取消委托
        Application.RegisterLogCallback(null);
    }
    //委托方法
    //方法名字可以自定义，但方法的参数类型要符合Application.LogCallback中的参数类型
    void MyCallback(string logString, string stackTrace, LogType type)
    {
        output = logString;
        stack = stackTrace;
        logType = type.ToString();
    }
}
