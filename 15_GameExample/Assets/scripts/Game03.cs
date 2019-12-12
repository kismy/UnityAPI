using UnityEngine;
using System.Collections;

/**
 * ����3��ÿ����Ϸ������Ŀ��ƴ���
 * */
public class Game03 : MonoBehaviour
{

    public Texture2D picture_bg;//����ͼƬ
    public Texture2D progress_f, progress_b;//������ǰ��ͼƬ
    float progress_length = 1;//������ʵʱ����
    bool is_press_enter = false;
    float bg_x = 0.0f;
    float add_frame01 = 1.0f;
    float add_frame02 = 1.0f;
    public static float Time_hold = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("��������Return��,���¿�ʼ��Ϸ");
            Application.LoadLevelAdditive(1);
            is_press_enter = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("��������Q�����˳���Ϸ");
            Application.Quit();
        }
        if (is_press_enter)
        {
            progress_length += add_frame01;
            add_frame01++;
        }
        if (progress_length >= 500)
        {
            is_press_enter = false;
            bg_x += add_frame02;
            add_frame02 += 3;
        }
        if (bg_x > Screen.width)
        {
            //��¼�¿�ʼʱ��
            Gamesetting.begin_time = Time.timeSinceLevelLoad;
            Gamesetting.which_step = 0;
            Destroy(this.gameObject);
        }
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(bg_x, 0.0f, Screen.width, Screen.height), picture_bg);
        if (is_press_enter)
        {
            GUI.DrawTexture(new Rect((Screen.width - 500) / 2, Screen.height - 50.0f, progress_length, 15.0f), progress_f);
            GUI.DrawTexture(new Rect((Screen.width - 500) / 2, Screen.height - 50.0f, 500.0f, 15.0f), progress_b);
        }

        GUIStyle gs=GUI.skin.customStyles[0];
        gs.fontSize = 50;//���������С
        GUI.Label(new Rect((Screen.width - 500) / 2, 60.0f, Screen.width - 500, 50.0f), "��������ϼ�����" + Time_hold + "��!", gs);
    }
}
