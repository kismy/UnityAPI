using UnityEngine;
using System.Collections;
/**
 * ����1����Ϸ��ʼǰ�Ŀ��ƴ���
 * */
public class Game01 : MonoBehaviour
{
    public Texture2D picture_bg;//����ͼƬ
    public Texture2D progress_f, progress_b;//������ǰ��ͼƬ
    float progress_length = 1;//��������ʵʱ����
    bool is_press_enter = false;//�Ƿ���enter����ʼ�����³���
    float bg_x = 0.0f;//����ͼƬ��X�����꣬���ڿ����������ƶ�
    float add_frame01 = 1.0f;
    float add_frame02 = 1.0f;
    bool is_load_over = false;

    // �첽���س���2����רҵ�����
    //������첽���أ�����ʹ��Application.LoadLevelAdditive(1);
    //�첽����ͨ�����ڼ�����Դ�϶࣬�Ƚ�����ʱ��������
    IEnumerator Start()
    {
        AsyncOperation async = Application.LoadLevelAdditiveAsync("Game02");
        //�첽������
        Debug.Log("1:" + async.isDone);//�Ƿ�������
        Debug.Log("2:" + async.progress);//���ؽ��ȣ���Χ0-1
        yield return async;
        //������ɺ�
        Debug.Log("3:" + async.isDone);
        Debug.Log("4:" + async.progress);
        is_load_over = async.isDone;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("��������Return��");
            //���첽��������ֵΪ1�ĳ��������ı䵱ǰ��������
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
        //������ͼƬ�Ƴ���Ļ����Ϸ��ʼ
        if (bg_x > Screen.width)
        {
            //��¼��Ϸ��ʼʱ��
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
