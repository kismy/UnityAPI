using UnityEngine;
using System.Collections;

public class PixelRect_ts : MonoBehaviour
{
    int which_change = -1;
    float temp_x = 0.0f, temp_y = 0.0f;
    void Update()
    {
        //Screen.width和Screen.height为模拟硬件屏幕的宽高值,
        //其返回值不随camera.pixelWidth和camera.pixelHeight的改变而改变
        Debug.Log("Screen.width:" + Screen.width);
        Debug.Log("Screen.height:" + Screen.height);
        Debug.Log("pixelWidth:" + camera.pixelWidth);
        Debug.Log("pixelHeight:" + camera.pixelHeight);
        //通过改变Camera的坐标位置而改变视口的区间
        if (which_change == 0)
        {
            if (camera.pixelWidth > 1.0f)
            {
                temp_x += Time.deltaTime * 20.0f;
            }
            //取消以下注释察看平移状况
            //if (camera.pixelHeight > 1.0f)
            //{
            //    temp_y += Time.deltaTime * 20.0f;
            //}
            camera.pixelRect = new Rect(temp_x, temp_y, camera.pixelWidth, camera.pixelHeight);
        }
        //通过改变Camera的视口宽度和高度来改变视口的区间
        else if (which_change == 1)
        {
            if (camera.pixelWidth > 1.0f)
            {
                temp_x = camera.pixelWidth - Time.deltaTime * 20.0f;
            }
            //取消以下注释察看平移状况
            //if (camera.pixelHeight > 1.0f)
            //{
            //    temp_y = camera.pixelHeight - Time.deltaTime * 20.0f;
            //}
            camera.pixelRect = new Rect(0, 0, temp_x, temp_y);
        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "视口改变方式1"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = 0;
            temp_x = 0.0f;
            temp_y = 0.0f;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "视口改变方式2"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = 1;
            temp_x = 0.0f;
            temp_y = camera.pixelHeight;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "视口还原"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = -1;
        }
    }
}