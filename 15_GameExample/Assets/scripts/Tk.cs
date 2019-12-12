using UnityEngine;
using System.Collections;

/**
 * 坦克控制
 * */

public class Tk : MonoBehaviour
{
    public int tk_value;//生命值
    public float tk_range;//坦克有效射程
    public float tk_fire_wait;//坦克开火间隔
    public static float tk_speed;//前进速度
    public Transform tk_pg;//炮管
    private Vector3 tk_pgaim;//炮管朝向目标的坐标
    public Vector3 tk_aim;//坦克前进的目标点
    public Transform tk_bullet;//子弹
    public Transform tk_fire_point;//开火点，即初始化子弹的位置
    public Transform tk_xt;//坦克血条
   
    /**
     * which_step:状态记录
     * -1:游戏未开始
     * 0：调整坦克方向
     * 1：前进
     * 2：调整炮管
     * 3：发射子弹
     * */
    public int which_step = Gamesetting.which_step;

    private Vector3 v3_temp = Vector3.zero;

    private int zero_count;//方向调整计时
    private int zero_count_max;//方向调整计时最大值
    private Vector3 zero_czjd;//每次插值角度

    private Vector3 first_last_point;//上一次坦克所在坐标 用于计算坦克是否受阻
    private int first_last_count;//用于遇阻检测间隔计时
    public static float min_len;//非遇阻情况下最短前进距离，按坡度30度计算
    private Vector3 first_len_last;//用于计算坦克前进距离
    private Vector3 first_current_point;//坦克当前坐标
    private bool first_is_turn_right;//前进目标相对于坦克的初始化位置 是否在坦克右边
    private int first_correct_count;//矫正方向时间间隔计数
    public int first_correct_count_max;//矫正方向时间间隔计最大值数
    private Vector3 first_go_v3;//前进方向变量
    public float first_frame_angle;//遇阻矫正角度时每次调整的角度值
    public int first_check_wait;//前进遇阻检测间隔
    private bool first_is_stop;//是否遇阻
    private int first_is_stop_count;//遇阻调整方向计数
    private int first_is_rotate_count;//方向矫正时计数

    private float near_toHp = 0.0f;
    private float third_time = 0.0f;
    private float xt_value = 0.0f;//血条值

    //初始化数据
    private void initial_data()
    {
        tk_value = Gamesetting.tk_values;//生命值
        tk_range = 1600;//射程 40平方
        tk_fire_wait = 3.0f;//开火间隔
        tk_speed = 8.0f; //前进速度
        tk_aim = Gamesetting.local_jq;//坦克前进目标
        
        zero_count = 0;
        zero_count_max = 150;//3秒内调整完毕

        first_correct_count_max = 500;//坦克调整方向的时间间隔
        first_frame_angle = 0.1f;//
        first_check_wait = 50 * 2;
        first_is_stop = false;
        first_is_stop_count = 0;
        first_is_rotate_count = 0;

        first_last_point = transform.position;
        first_last_count = 0;
        min_len = tk_speed * tk_speed * 0.75f; //以平方计算
        tk_speed = tk_speed * 0.02f;
        turnRightOrLeft();
        if (this.transform.up.y < 0)
        {
            this.transform.up = new Vector3(this.transform.up.x, -this.transform.up.y, this.transform.up.z);
        }
        first_go_v3 = tk_aim - transform.position;
        first_go_v3.y = 0;
        this.transform.forward = first_go_v3.normalized;
        first_correct_count = 0;

    }
    //判断坦克左拐还是右拐
    private void turnRightOrLeft()
    {
        Vector3 v3 = tk_aim - transform.position;
        if ((v3.x > 0 && v3.z > 0) || (v3.x < 0 && v3.z < 0))
        {
            first_is_turn_right = true;
        }
        else
        {
            first_is_turn_right = false;
        }
    }

    //调整方向
    private void step_zero()
    {
        Vector3 vt = Vector3.MoveTowards(transform.forward, (tk_aim - transform.position).normalized, Time.time * 0.001f);
        float _x = (v3_temp.x - vt.x) * (v3_temp.x - vt.x) + (v3_temp.z - vt.z) * (v3_temp.z - vt.z);

        v3_temp = vt;
        vt = vt.normalized;
        zero_count++;
        if (_x != 0.0f && zero_count < zero_count_max)
        {
            transform.forward = vt;
        }
        else
        {
            which_step = 1;
            turnRightOrLeft();
            zero_count = 0;
        }
    }

    //前进-update
    private void step_first_update()
    {
        //坦克侧翻时 需要矫正
        if (this.transform.up.y < 0)
        {
            this.transform.up = new Vector3(this.transform.up.x, 2.0f-this.transform.up.y, this.transform.up.z);
        }

        float f1=Vector3.Angle(transform.forward,Vector3.up);
        float f2=Vector3.Angle(transform.right,Vector3.up);
        //当坡度太陡时认为坦克遇阻，此处Z轴偏移不得大于44度，X偏移不得大于30度
        if(f1<46.0f||f1>134||f2<60||f2>120){
            first_is_stop = true;
        }
        //坦克每隔first_correct_count_max帧调整一次前进方向
        if (first_correct_count < first_correct_count_max)
        {
            first_correct_count++;

        }
        else
        {
            first_go_v3 = tk_aim - this.transform.position;
            first_go_v3 = (first_go_v3.normalized - this.transform.forward) / 64;
            first_is_rotate_count = 64;
            first_correct_count = 0;

            first_is_stop = false;
            first_is_stop_count = 0;
            first_last_count = 0;
            first_last_point = first_current_point;
        }
        //调整方向
        if (first_is_rotate_count > 0)
        {
            this.transform.forward += first_go_v3;
            first_is_rotate_count--;
            first_correct_count = 0;
        }
        //遇阻后方向调整
        if (first_is_stop)
        {
            if (first_is_turn_right)
            {
                transform.Rotate(Vector3.up, first_frame_angle, Space.Self);
            }
            else
            {
                transform.Rotate(Vector3.down, first_frame_angle, Space.Self);
            }
            first_is_stop_count++;
            //调整角度大于50度后结束
            if (first_is_stop_count * first_frame_angle > 50)
            {
                first_is_stop = false;
                first_is_stop_count = 0;
                first_last_count = 0;
                first_last_point = first_current_point;
            }
            first_correct_count = 0;
        }
    }

    //前进-FixedUpdate
    private void step_first_fixedUpdate()
    {
        //如果坦克未遇阻
        if (!first_is_stop)
        {
            //每隔first_check_wait时间检测一次坦克前进距离
            if (first_last_count < first_check_wait)
            {
                first_last_count++;
                transform.Translate(transform.forward * tk_speed, Space.World);
            }
            else
            {
                first_current_point = transform.position;
                first_len_last = first_current_point - first_last_point;
                //当前进距离过小时认为坦克遇阻
                if (first_len_last.x * first_len_last.x + first_len_last.z * first_len_last.z < min_len)
                {
                    first_is_stop = true;
                }
                else
                {
                    first_is_stop = false;
                    first_last_count = 0;
                    first_last_point = first_current_point;
                    first_is_stop_count = 0;
                }

            }
        }
    }
    //调整炮管
    private void step_second()
    {
        Vector3 vt = Vector3.MoveTowards(tk_pg.transform.forward, (tk_pgaim - tk_pg.transform.position).normalized, Time.time * 0.001f);

        float _x = (v3_temp.x - vt.x) * (v3_temp.x - vt.x) + (v3_temp.z - vt.z) * (v3_temp.z - vt.z);

        if (_x != 0.0f)
        {
            v3_temp = vt;
            tk_pg.transform.forward = vt.normalized;
        }
        else
        {
            v3_temp = Vector3.zero;
            which_step = 3;
        }
    }
    //发射子弹
    private void step_third()
    {
        if (third_time < tk_fire_wait)
        {
            third_time += Time.deltaTime;
        }
        else
        {
            //实例化子弹
            Instantiate(tk_bullet, tk_fire_point.position, tk_pg.transform.rotation);
            third_time = 0.0f;
        }
    }

    // Use this for initialization
    void Start()
    {
        Invoke("initial_data", Random.Range(0.1f, 1.0f));
        Invoke("caculate_xt_value", 1.2f);
        InvokeRepeating("caculate_xt_foward", 0.2f, 0.2f);
    }
    //判断坦克当前与机枪距离的状态 可能在坦克射程内
    private void is_nearToHp()
    {
        //每隔0.8秒检测一次距离
        if (near_toHp > 0.8f)
        {
            near_toHp = 0.0f;
            v3_temp = Gamesetting.local_jq - transform.position;
            float len_temp = v3_temp.x * v3_temp.x + v3_temp.z * v3_temp.z;
            //是否在坦克射程内
            if (len_temp < tk_range)
            {
                which_step = 2;
                tk_pgaim = Gamesetting.local_jq;
            }
        }
        else
        {
            near_toHp += Time.deltaTime;
        }
    }

    //计算血条值
    private void caculate_xt_value()
    {
        xt_value = ((float)tk_value / Gamesetting.tk_values) * 0.5f;
        xt_value = xt_value > 0.5f ? 0.5f : xt_value;
        tk_xt.renderer.material.SetTextureOffset("_MainTex", new Vector2(xt_value, 0.0f));
    }
    //计算血条的朝向，使血条始终朝向摄像机
    private void caculate_xt_foward()
    {
        Vector3 dot = Vector3.zero;
        dot.x = Camera.main.transform.eulerAngles.x - 90.0f;
        dot.y = Camera.main.transform.eulerAngles.y;
        tk_xt.transform.eulerAngles = dot;
    }

    // Update is called once per frame
    void Update()
    {
        switch (which_step)
        {
            case 0://调整方向
                break;
            case 1://前进
                step_first_update();
                is_nearToHp();
                break;
            case 2://炮管
                break;
            case 3://发射子弹
                step_third();
                break;
            case -1:
                which_step = Gamesetting.which_step;
                break;
        }
    }

    void FixedUpdate()
    {
        switch (which_step)
        {
            case 0:
                step_zero();
                break;
            case 1:
                step_first_fixedUpdate();
                break;
            case 2:
                step_second();
                break;
            case 3:
                break;
        }
    }

    void OnTriggerEnter(Collider otherObject)
    {
        //被机枪子弹击中 则减血
        if (otherObject.tag == "jq_pd")
        {
            Debug.Log(" OnTriggerEnter TK:" + otherObject.tag);
            tk_value -= 20;
            caculate_xt_value();
            if (tk_value < 0)
            {
                //销毁坦克
                tk_value = 0;
                Gamesetting.num_tk--;
                Gamesetting.tk_des_num++;
                Gamesetting.money += 100;
                Destroy(this.gameObject);
            }
        }
        //坦克相撞 发生位移 需要调整炮管方向
        if (otherObject.tag == "tk")
        {
            which_step = 2;
        }
        //被别的坦克炮弹击中也减血
        if (otherObject.tag == "tk_pd")
        {
            tk_value -= 10;
            caculate_xt_value();
            if (tk_value < 0)
            {//销毁坦克
                tk_value = 0;
                Gamesetting.num_tk--;
                Gamesetting.tk_des_num++;
                Gamesetting.money += 100;
                Destroy(this.gameObject);
            }
        }
    }
}
