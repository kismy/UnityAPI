using UnityEngine;
using System.Collections;

/**
 * ̹�˿���
 * */

public class Tk : MonoBehaviour
{
    public int tk_value;//����ֵ
    public float tk_range;//̹����Ч���
    public float tk_fire_wait;//̹�˿�����
    public static float tk_speed;//ǰ���ٶ�
    public Transform tk_pg;//�ڹ�
    private Vector3 tk_pgaim;//�ڹܳ���Ŀ�������
    public Vector3 tk_aim;//̹��ǰ����Ŀ���
    public Transform tk_bullet;//�ӵ�
    public Transform tk_fire_point;//����㣬����ʼ���ӵ���λ��
    public Transform tk_xt;//̹��Ѫ��
   
    /**
     * which_step:״̬��¼
     * -1:��Ϸδ��ʼ
     * 0������̹�˷���
     * 1��ǰ��
     * 2�������ڹ�
     * 3�������ӵ�
     * */
    public int which_step = Gamesetting.which_step;

    private Vector3 v3_temp = Vector3.zero;

    private int zero_count;//���������ʱ
    private int zero_count_max;//���������ʱ���ֵ
    private Vector3 zero_czjd;//ÿ�β�ֵ�Ƕ�

    private Vector3 first_last_point;//��һ��̹���������� ���ڼ���̹���Ƿ�����
    private int first_last_count;//��������������ʱ
    public static float min_len;//��������������ǰ�����룬���¶�30�ȼ���
    private Vector3 first_len_last;//���ڼ���̹��ǰ������
    private Vector3 first_current_point;//̹�˵�ǰ����
    private bool first_is_turn_right;//ǰ��Ŀ�������̹�˵ĳ�ʼ��λ�� �Ƿ���̹���ұ�
    private int first_correct_count;//��������ʱ��������
    public int first_correct_count_max;//��������ʱ���������ֵ��
    private Vector3 first_go_v3;//ǰ���������
    public float first_frame_angle;//��������Ƕ�ʱÿ�ε����ĽǶ�ֵ
    public int first_check_wait;//ǰ����������
    private bool first_is_stop;//�Ƿ�����
    private int first_is_stop_count;//��������������
    private int first_is_rotate_count;//�������ʱ����

    private float near_toHp = 0.0f;
    private float third_time = 0.0f;
    private float xt_value = 0.0f;//Ѫ��ֵ

    //��ʼ������
    private void initial_data()
    {
        tk_value = Gamesetting.tk_values;//����ֵ
        tk_range = 1600;//��� 40ƽ��
        tk_fire_wait = 3.0f;//������
        tk_speed = 8.0f; //ǰ���ٶ�
        tk_aim = Gamesetting.local_jq;//̹��ǰ��Ŀ��
        
        zero_count = 0;
        zero_count_max = 150;//3���ڵ������

        first_correct_count_max = 500;//̹�˵��������ʱ����
        first_frame_angle = 0.1f;//
        first_check_wait = 50 * 2;
        first_is_stop = false;
        first_is_stop_count = 0;
        first_is_rotate_count = 0;

        first_last_point = transform.position;
        first_last_count = 0;
        min_len = tk_speed * tk_speed * 0.75f; //��ƽ������
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
    //�ж�̹����ջ����ҹ�
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

    //��������
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

    //ǰ��-update
    private void step_first_update()
    {
        //̹�˲෭ʱ ��Ҫ����
        if (this.transform.up.y < 0)
        {
            this.transform.up = new Vector3(this.transform.up.x, 2.0f-this.transform.up.y, this.transform.up.z);
        }

        float f1=Vector3.Angle(transform.forward,Vector3.up);
        float f2=Vector3.Angle(transform.right,Vector3.up);
        //���¶�̫��ʱ��Ϊ̹�����裬�˴�Z��ƫ�Ʋ��ô���44�ȣ�Xƫ�Ʋ��ô���30��
        if(f1<46.0f||f1>134||f2<60||f2>120){
            first_is_stop = true;
        }
        //̹��ÿ��first_correct_count_max֡����һ��ǰ������
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
        //��������
        if (first_is_rotate_count > 0)
        {
            this.transform.forward += first_go_v3;
            first_is_rotate_count--;
            first_correct_count = 0;
        }
        //����������
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
            //�����Ƕȴ���50�Ⱥ����
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

    //ǰ��-FixedUpdate
    private void step_first_fixedUpdate()
    {
        //���̹��δ����
        if (!first_is_stop)
        {
            //ÿ��first_check_waitʱ����һ��̹��ǰ������
            if (first_last_count < first_check_wait)
            {
                first_last_count++;
                transform.Translate(transform.forward * tk_speed, Space.World);
            }
            else
            {
                first_current_point = transform.position;
                first_len_last = first_current_point - first_last_point;
                //��ǰ�������Сʱ��Ϊ̹������
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
    //�����ڹ�
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
    //�����ӵ�
    private void step_third()
    {
        if (third_time < tk_fire_wait)
        {
            third_time += Time.deltaTime;
        }
        else
        {
            //ʵ�����ӵ�
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
    //�ж�̹�˵�ǰ���ǹ�����״̬ ������̹�������
    private void is_nearToHp()
    {
        //ÿ��0.8����һ�ξ���
        if (near_toHp > 0.8f)
        {
            near_toHp = 0.0f;
            v3_temp = Gamesetting.local_jq - transform.position;
            float len_temp = v3_temp.x * v3_temp.x + v3_temp.z * v3_temp.z;
            //�Ƿ���̹�������
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

    //����Ѫ��ֵ
    private void caculate_xt_value()
    {
        xt_value = ((float)tk_value / Gamesetting.tk_values) * 0.5f;
        xt_value = xt_value > 0.5f ? 0.5f : xt_value;
        tk_xt.renderer.material.SetTextureOffset("_MainTex", new Vector2(xt_value, 0.0f));
    }
    //����Ѫ���ĳ���ʹѪ��ʼ�ճ��������
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
            case 0://��������
                break;
            case 1://ǰ��
                step_first_update();
                is_nearToHp();
                break;
            case 2://�ڹ�
                break;
            case 3://�����ӵ�
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
        //����ǹ�ӵ����� ���Ѫ
        if (otherObject.tag == "jq_pd")
        {
            Debug.Log(" OnTriggerEnter TK:" + otherObject.tag);
            tk_value -= 20;
            caculate_xt_value();
            if (tk_value < 0)
            {
                //����̹��
                tk_value = 0;
                Gamesetting.num_tk--;
                Gamesetting.tk_des_num++;
                Gamesetting.money += 100;
                Destroy(this.gameObject);
            }
        }
        //̹����ײ ����λ�� ��Ҫ�����ڹܷ���
        if (otherObject.tag == "tk")
        {
            which_step = 2;
        }
        //�����̹���ڵ�����Ҳ��Ѫ
        if (otherObject.tag == "tk_pd")
        {
            tk_value -= 10;
            caculate_xt_value();
            if (tk_value < 0)
            {//����̹��
                tk_value = 0;
                Gamesetting.num_tk--;
                Gamesetting.tk_des_num++;
                Gamesetting.money += 100;
                Destroy(this.gameObject);
            }
        }
    }
}
