using UnityEngine;
using System.Collections;

public class CaptureScreenshot_ts : MonoBehaviour
{
    int tp = -1;
    void Update()
    {
        if (tp == 0)
        {
            //默认值，不放大
            Application.CaptureScreenshot("test01.png", 0);
        }
        else if (tp == 1)
        {
            //放大系数为1，即不放大
            Application.CaptureScreenshot("test02.png", 1);
        }
        else
        {
            //放大系数为2，即放大2倍
            Application.CaptureScreenshot("test03.png", 2);
        }
        tp++;
    }
}
