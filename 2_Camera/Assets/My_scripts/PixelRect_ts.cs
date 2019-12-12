using UnityEngine;
using System.Collections;

public class PixelRect_ts : MonoBehaviour
{
    int which_change = -1;
    float temp_x = 0.0f, temp_y = 0.0f;
    void Update()
    {
        //Screen.width��Screen.heightΪģ��Ӳ����Ļ�Ŀ��ֵ,
        //�䷵��ֵ����camera.pixelWidth��camera.pixelHeight�ĸı���ı�
        Debug.Log("Screen.width:" + Screen.width);
        Debug.Log("Screen.height:" + Screen.height);
        Debug.Log("pixelWidth:" + camera.pixelWidth);
        Debug.Log("pixelHeight:" + camera.pixelHeight);
        //ͨ���ı�Camera������λ�ö��ı��ӿڵ�����
        if (which_change == 0)
        {
            if (camera.pixelWidth > 1.0f)
            {
                temp_x += Time.deltaTime * 20.0f;
            }
            //ȡ������ע�Ͳ쿴ƽ��״��
            //if (camera.pixelHeight > 1.0f)
            //{
            //    temp_y += Time.deltaTime * 20.0f;
            //}
            camera.pixelRect = new Rect(temp_x, temp_y, camera.pixelWidth, camera.pixelHeight);
        }
        //ͨ���ı�Camera���ӿڿ�Ⱥ͸߶����ı��ӿڵ�����
        else if (which_change == 1)
        {
            if (camera.pixelWidth > 1.0f)
            {
                temp_x = camera.pixelWidth - Time.deltaTime * 20.0f;
            }
            //ȡ������ע�Ͳ쿴ƽ��״��
            //if (camera.pixelHeight > 1.0f)
            //{
            //    temp_y = camera.pixelHeight - Time.deltaTime * 20.0f;
            //}
            camera.pixelRect = new Rect(0, 0, temp_x, temp_y);
        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10.0f, 10.0f, 200.0f, 45.0f), "�ӿڸı䷽ʽ1"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = 0;
            temp_x = 0.0f;
            temp_y = 0.0f;
        }
        if (GUI.Button(new Rect(10.0f, 60.0f, 200.0f, 45.0f), "�ӿڸı䷽ʽ2"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = 1;
            temp_x = 0.0f;
            temp_y = camera.pixelHeight;
        }
        if (GUI.Button(new Rect(10.0f, 110.0f, 200.0f, 45.0f), "�ӿڻ�ԭ"))
        {
            camera.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
            which_change = -1;
        }
    }
}