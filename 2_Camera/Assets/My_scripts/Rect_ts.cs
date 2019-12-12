using UnityEngine;
using System.Collections;

public class Rect_ts : MonoBehaviour
{
    int which_change = -1;
    float temp_x = 0.0f, temp_y = 0.0f;
    void Update()
    {
        //视口平移
        if (which_change == 0)
        {
            if (camera.rect.x < 1.0f)
            {
                //沿着X轴平移
                temp_x = camera.rect.x + Time.deltaTime * 0.2f;
            }
            //取消下面注释察看平移的变化
            //if (camera.rect.y< 1.0f)
            //{
                //沿着Y轴平移
            //    temp_y = camera.rect.y + Time.deltaTime * 0.2f;
            //}
            camera.rect = new Rect(temp_x, temp_y, camera.rect.width, camera.rect.height);
        }
         //视口放缩
        else if (which_change == 1)
        {
            if (camera.rect.width > 0.0f)
            {
                //沿着X轴放缩
                temp_x = camera.rect.width - Time.deltaTime * 0.2f;
            }
            if (camera.rect.height > 0.0f)
            {
                //沿着Y轴放缩
                temp_y = camera.rect.height - Time.deltaTime * 0.2f;
            }
            camera.rect = new Rect(camera.rect.x, camera.rect.y, temp_x, temp_y);
        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "视口平移"))
        {
            //重置视口
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = 0;
            temp_y = 0.0f;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "视口放缩"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = 1;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "视口还原"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = -1;
        }
    }
}
