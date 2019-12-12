using UnityEngine;
using System.Collections;

public class Dot_ts : MonoBehaviour {
    public Transform A, B;
    Vector3 A_lv, AB_v;
    string str = "";

    void Update()
    {
        //��A����������ϵ��forward����ת��ʱ������ϵ��
        A_lv = A.TransformDirection(Vector3.forward); 
        //A��B�Ĳ�����
        AB_v = B.position-A.position;
        float f = Vector3.Dot(A_lv, AB_v);
        if(f>0){
            str = "B��A��������ϵ��ǰ��";
        }
        else if (f < 0)
        {
            str = "B��A��������ϵ�ĺ�";
        }
        else {
            str = "B��A��������ϵ�����󷽻��ҷ�";
        }
        //��תA����ʹ��A������forward���򲻶ϸı�
        //��ȻA��B���������궼δ�ı䣬������������ϵ��A��B��λ�ù�ϵû�иı�
        //����A����������ϵ��B�����λ���ڲ��ϸı�
        A.Rotate(new Vector3(0.0f,1.0f,0.0f));
    }
    void OnGUI(){
        GUI.Label(new Rect(10.0f,10.0f,200.0f,60.0f),str);
    }
}