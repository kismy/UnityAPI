using UnityEngine;
using System.Collections;

/**
 * 场景3即每局游戏结束后的控制代码
 * */
public class Game03 : MonoBehaviour
{

    public Texture2D picture_bg;//背景图片
    public Texture2D progress_f, progress_b;//进度条前后图片
    float progress_length = 1;//进度条实时长度
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
            Debug.Log("您按下了Return键,重新开始游戏");
            Application.LoadLevelAdditive(1);
            is_press_enter = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("您按下了Q键，退出游戏");
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
            //记录新开始时间
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
        gs.fontSize = 50;//设置字体大小
        GUI.Label(new Rect((Screen.width - 500) / 2, 60.0f, Screen.width - 500, 50.0f), "您在阵地上坚守了" + Time_hold + "秒!", gs);
    }
}
