using UnityEngine;
using System.Collections;

public class EventMask_ts : MonoBehaviour
{
    bool is_rotate = false;//控制物体旋转
    public Camera c;//指向场景中摄像机
    //记录摄像机的eventMask值，可以在程序运行时在Inspector面板中修改其值的大小
    public int eventMask_now = -1;
    //记录当前物体的层
    int layer_now;
    int tp;//记录2的layer次方的值
    int ad;//记录与运算（&）的结果
    string str = null;

    void Update()
    {
        //记录当前对象的层，可以在程序运行时在Inspector面板中选择不同的层
        layer_now = gameObject.layer;
        //求2的layer_now次方的值
        tp = (int)Mathf.Pow(2.0f, layer_now);
        //与运算（&）
        ad = eventMask_now & tp;
        c.eventMask = eventMask_now;
        //当is_rotate为true时旋转物体
        if (is_rotate)
        {
            transform.Rotate(Vector3.up * 15.0f * Time.deltaTime);
        }
    }
    //当鼠标左键按下时，物体开始旋转
    void OnMouseDown()
    {
        is_rotate = true;
    }
    //当鼠标左键抬起时，物体结束旋转
    void OnMouseUp()
    {
        is_rotate = false;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10.0f, 10.0f, 300.0f, 45.0f), "当前对象的layer值为：" + layer_now + " , 2的layer次方的值为" + tp);
        GUI.Label(new Rect(10.0f, 60.0f, 300.0f, 45.0f), "当前摄像机eventMask的值为：" + eventMask_now);
        GUI.Label(new Rect(10.0f, 110.0f, 500.0f, 45.0f), "根据算法，当eventMask的值与" + tp + "进行与运算（&）后， 若结果为" + tp + "，则物体相应OnMousexxx方法，否则不响应！");

        if (ad == tp)
        {
            str = " ,所以物体会相应OnMouseXXX方法！";
        }
        else
        {
            str = " ,所以物体不会相应OnMouseXXX方法！";
        }
        GUI.Label(new Rect(10.0f, 160.0f, 500.0f, 45.0f), "而当前eventMask与" + tp + "进行与运算（&）的结果为" + ad + str);
    }
}
