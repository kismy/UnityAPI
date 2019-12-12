using UnityEngine;
using System.Collections;

public class Dot_ts : MonoBehaviour {
    public Transform A, B;
    Vector3 A_lv, AB_v;
    string str = "";

    void Update()
    {
        //将A的自身坐标系的forward向量转向时间坐标系中
        A_lv = A.TransformDirection(Vector3.forward); 
        //A到B的差向量
        AB_v = B.position-A.position;
        float f = Vector3.Dot(A_lv, AB_v);
        if(f>0){
            str = "B在A自身坐标系的前方";
        }
        else if (f < 0)
        {
            str = "B在A自身坐标系的后方";
        }
        else {
            str = "B在A自身坐标系的正左方或右方";
        }
        //旋转A物体使得A的自身forward方向不断改变
        //虽然A、B的世界坐标都未改变，且在世界坐标系中A和B的位置关系没有改变
        //但在A的自身坐标系中B的相对位置在不断改变
        A.Rotate(new Vector3(0.0f,1.0f,0.0f));
    }
    void OnGUI(){
        GUI.Label(new Rect(10.0f,10.0f,200.0f,60.0f),str);
    }
}