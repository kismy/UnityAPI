using UnityEngine;
using System.Collections;

public class CaptureScreenshot_ts : MonoBehaviour
{
    int tp = -1;
    void Update()
    {
        if (tp == 0)
        {
            //Ĭ��ֵ�����Ŵ�
            Application.CaptureScreenshot("test01.png", 0);
        }
        else if (tp == 1)
        {
            //�Ŵ�ϵ��Ϊ1�������Ŵ�
            Application.CaptureScreenshot("test02.png", 1);
        }
        else
        {
            //�Ŵ�ϵ��Ϊ2�����Ŵ�2��
            Application.CaptureScreenshot("test03.png", 2);
        }
        tp++;
    }
}
