using UnityEngine;
using System.Collections;
/**
 * ��ǹ����
 * */
public class Jiqiang : MonoBehaviour
{
    //������ʱ��ǹÿ֡���·���ı�Ƕ�
    private float frame_angel_du = 0.3f;
    //������ʱ��ǹÿ֡���ҷ���ı�Ƕ�
    private float frame_angel_lr = 0.4f;
    //��¼��ǹ���½Ƕȸı����ֵ������Ƕȹ���
    private float angle_down_up = 0;
    //��ǹ��ǰ����ֵ
    private int current_value;
    //Ѫ������
    private float xt_length;
    //��ǹ�ڵ�
    public Transform jq_pd;
    //��ǹ�ڵ�ʵ����λ��
    public Transform jq_kh_point;
    //Ѫ��ͼƬ
    public Texture2D xt_b;
    public Texture2D xt_f;

    void Start()
    {
        current_value = Gamesetting.jq_values;
        xt_length = 300.0f;
    }

    void Update()
    {
        //W����ǹ��ת
        if (Input.GetKey(KeyCode.W) && angle_down_up < 30.0f)
        {
            Debug.Log("��������W��" + angle_down_up);
            angle_down_up += frame_angel_du;
            //��ǹ������ת�Ĳο�����ϵΪ��������ϵ����Ĭ��ֵspace.self
            transform.Rotate(Vector3.right, -frame_angel_du);
        }
        //S:��ǹ��ת
        if (Input.GetKey(KeyCode.S) && angle_down_up > -25.0f)
        {
            Debug.Log("��������S��" + angle_down_up);
            angle_down_up -= frame_angel_du;
            transform.Rotate(Vector3.right, frame_angel_du);
        }
        //A:��ǹ��ת
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("��������A��");
            //��ǹ������ת�ο�����ϵ��ҪΪ��������ϵ��������������ת���ٽ���������תʱ�����
            transform.Rotate(Vector3.up, -frame_angel_lr, Space.World);
        }
        //D:��ǹ��ת
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("��������D��");
            transform.Rotate(Vector3.up, frame_angel_lr, Space.World);
        }
        //����������
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("��������������");
            Instantiate(jq_pd, jq_kh_point.position, transform.rotation);
        }
        //����Ҽ���Ѫ
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("������������Ҽ�");
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
        GUI.Label(new Rect(Screen.width - 150.0f, 10.0f, 120.0f, 25.0f), "���֣�" + Gamesetting.money);
        GUI.Label(new Rect(10.0f, 50.0f, 500.0f, 50.0f), "W��A��S��D���ı��ǹ����\n�����������Ҽ���Ѫ");
        GUI.Label(new Rect(10.0f, 120.0f, 500.0f, 50.0f), "����̹��"+Gamesetting.tk_des_num+"��\n��"+Gamesetting.num_tk+"��̹������Ϯ��������");
        GUI.Label(new Rect(10.0f, Screen.height - 50.0f, 190.0f, 25.0f), "��Ϸ����ʱ�䣺" + (int)(Time.timeSinceLevelLoad - Gamesetting.begin_time) + "��");
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
                //����ֵ��0
                current_value = 0;
                Gamesetting.which_step = -1;
                Game03.Time_hold = (int)(Time.timeSinceLevelLoad - Gamesetting.begin_time);
                //��Ϸ�����������³���
                Application.LoadLevel(2);
            }
        }
    }
}
