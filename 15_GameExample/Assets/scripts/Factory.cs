using UnityEngine;
using System.Collections;

/**
 * ������,��������̹��
 * */

public class Factory : MonoBehaviour
{
    public Transform tks;//ʵ����̹�˶���
    private Vector3 creat_tk_position;//ʵ����̹��λ��

    void Start()
    {
        //̹��ʵ������λ�����������λ�÷���һ����ƫ�ƣ�����ģ��֮�����������͸
        creat_tk_position = this.transform.position + new Vector3(10.0f, 4.0f, 10.0f);
        //��Ϸ������2�뿪ʼ���÷���creat_tk���Ժ�ÿ��10�����һ�δ˷���
        InvokeRepeating("creat_tk", 2.0f, 10.0f);
    }
    //ʵ����̹��
    private void creat_tk()
    {
        //����Ϸ��̹������������Ϸ���õ����̹������ʱ��ʵ����һ����̹��
        if (Gamesetting.num_tk < Gamesetting.tk_max_num)
        {
            Gamesetting.num_tk++;
            Instantiate(tks, creat_tk_position, Quaternion.identity);
        }
    }
}
