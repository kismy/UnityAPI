using UnityEngine;
using System.Collections;
/**
 * 场景1即游戏开始前的控制代码
 * */
public class Game01 : MonoBehaviour
{
    public Texture2D picture_bg;//背景图片
    public Texture2D progress_f, progress_b;//进度条前后图片
    float progress_length = 1;//进度条的实时长度
    bool is_press_enter = false;//是否按下enter键开始加载新场景
    float bg_x = 0.0f;//背景图片的X轴坐标，用于控制其向右移动
    float add_frame01 = 1.0f;
    float add_frame02 = 1.0f;
    bool is_load_over = false;

    // 异步加载场景2，仅专业版可用
    //如果非异步加载，可以使用Application.LoadLevelAdditive(1);
    //异步加载通常用在加载资源较多，比较消耗时间的情况下
    IEnumerator Start()
    {
        AsyncOperation async = Application.LoadLevelAdditiveAsync("Game02");
        //异步加载中
        Debug.Log("1:" + async.isDone);//是否加载完成
        Debug.Log("2:" + async.progress);//加载进度，范围0-1
        yield return async;
        //加载完成后
        Debug.Log("3:" + async.isDone);
        Debug.Log("4:" + async.progress);
        is_load_over = async.isDone;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("您按下了Return键");
            //非异步加载索引值为1的场景，不改变当前场景内容
            //Application.LoadLevelAdditive(1);
            is_press_enter = true;
        }
        if (is_press_enter)
        {
            progress_length += add_frame01;
            add_frame01++;
        }
        if (progress_length >= 500 && is_load_over)
        {
            is_press_enter = false;
            bg_x += add_frame02;
            add_frame02 += 3;
        }
        //当背景图片移出屏幕后，游戏开始
        if (bg_x > Screen.width)
        {
            //记录游戏开始时间
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
    }
}
