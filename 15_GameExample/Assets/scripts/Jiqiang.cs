using UnityEngine;
using System.Collections;
/**
 * 机枪控制
 * */
public class Jiqiang : MonoBehaviour
{
    //当按键时机枪每帧上下方向改变角度
    private float frame_angel_du = 0.3f;
    //当按键时机枪每帧左右方向改变角度
    private float frame_angel_lr = 0.4f;
    //记录机枪上下角度改变的总值，避免角度过大
    private float angle_down_up = 0;
    //机枪当前生命值
    private int current_value;
    //血条长度
    private float xt_length;
    //机枪炮弹
    public Transform jq_pd;
    //机枪炮弹实例化位置
    public Transform jq_kh_point;
    //血条图片
    public Texture2D xt_b;
    public Texture2D xt_f;

    void Start()
    {
        current_value = Gamesetting.jq_values;
        xt_length = 300.0f;
    }

    void Update()
    {
        //W：机枪上转
        if (Input.GetKey(KeyCode.W) && angle_down_up < 30.0f)
        {
            Debug.Log("您按下了W键" + angle_down_up);
            angle_down_up += frame_angel_du;
            //机枪上下旋转的参考坐标系为自身坐标系，即默认值space.self
            transform.Rotate(Vector3.right, -frame_angel_du);
        }
        //S:机枪下转
        if (Input.GetKey(KeyCode.S) && angle_down_up > -25.0f)
        {
            Debug.Log("您按下了S键" + angle_down_up);
            angle_down_up -= frame_angel_du;
            transform.Rotate(Vector3.right, frame_angel_du);
        }
        //A:机枪左转
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("您按下了A键");
            //机枪左右旋转参考坐标系需要为世界坐标系，否则在上下旋转后再进行左右旋转时会变形
            transform.Rotate(Vector3.up, -frame_angel_lr, Space.World);
        }
        //D:机枪右转
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("您按下了D键");
            transform.Rotate(Vector3.up, frame_angel_lr, Space.World);
        }
        //鼠标左键开火
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("您按下了鼠标左键");
            Instantiate(jq_pd, jq_kh_point.position, transform.rotation);
        }
        //鼠标右键补血
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("您按下了鼠标右键");
            if (Gamesetting.money >= 300 && current_value < 300)
            {
                Gamesetting.money -= 300;
                current_value = Gamesetting.jq_values;
                xt_length = ((float)current_value / Gamesetting.jq_values) * 300.0f;
            }
        }
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(10.0f, 10.0f, xt_length, 25.0f), xt_f);
        GUI.DrawTexture(new Rect(10.0f, 10.0f, 300.0f, 25.0f), xt_b);
        GUI.contentColor = Color.green;
        GUI.Label(new Rect(Screen.width - 150.0f, 10.0f, 120.0f, 25.0f), "积分：" + Gamesetting.money);
        GUI.Label(new Rect(10.0f, 50.0f, 500.0f, 50.0f), "W、A、S、D键改变机枪方向\n鼠标左键开火，右键补血");
        GUI.Label(new Rect(10.0f, 120.0f, 500.0f, 50.0f), "击毁坦克"+Gamesetting.tk_des_num+"辆\n有"+Gamesetting.num_tk+"辆坦克正在袭来！！！");
        GUI.Label(new Rect(10.0f, Screen.height - 50.0f, 190.0f, 25.0f), "游戏运行时间：" + (int)(Time.timeSinceLevelLoad - Gamesetting.begin_time) + "秒");
    }

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "tk_pd")
        {
            Debug.Log(" OnTriggerEnter jq:" + otherObject.tag);
            current_value -= 20;
            xt_length = ((float)current_value / Gamesetting.jq_values) * 300.0f;
            if (current_value < 0)
            {
                //生命值归0
                current_value = 0;
                Gamesetting.which_step = -1;
                Game03.Time_hold = (int)(Time.timeSinceLevelLoad - Gamesetting.begin_time);
                //游戏结束，加载新场景
                Application.LoadLevel(2);
            }
        }
    }
}
