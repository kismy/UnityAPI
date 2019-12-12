using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
/**
 * ȫ�����ã����ڿ���ÿ����Ϸ�ж����ʵ����
 * */

public class Gamesetting : MonoBehaviour
{
    //ָ��Transform
    public Transform tran_tk;//̹��
    public Transform tran_factory;//������
    public Transform tran_jq;//��ǹ

    //���ڼ�¼ÿ����Ϸ�Ŀ�ʼʱ��
    public static float begin_time;

    public int num_guanqia = 1;//��ǰ�ؿ�ֵ������ȷ�������ĸ��ؿ�����
    public static Vector3 local_jq;//��ǹ�ĳ�ʼ��λ��
    public static int jq_values;//��ǹ�ĳ�ʼ������ֵ
    public static int num_tk;//��ʼ��̹������
    public static int tk_values;//̹�˵ĳ�ʼ������ֵ
    public static int factory_values;//�������ĳ�ʼ������ֵ
    public static int tk_max_num;//̹�����������ֵ

    public static int factory_num;//����������
    public static int money;//����ֵ��¼����ǹÿ����һ��ѪҪ����һ������

    public int tk_cur_num;//��ǰ������̹�����ֵ����ֵ�����ڸ���ʵ������̹������
    public static int tk_des_num;//����̹������

    public Terrain my_ter;//��ȡ��ǰս�������Ա��ȡ�������Ϣ
    public float ter_width;//���ο�ȣ�x
    public float ter_length;//���γ��ȣ�z
    public static float ter_height;//���θ߶ȣ�y

    //��ʼ��̹��λ��ʱ��̹�˾����ǹ����������ƽ��ֵ
    //һ����ԣ���Ϸ��ʼʱ��̹����Ҫ��Զ���ӽ���ǹλ�ã�������̹�˵���Ч���ʱ��Ի�ǹ���й���
    //Ӧ����һ��ʼ�Ͱ�̹�˵�λ�÷ŵľ����ǹ̫��
    public static float length_to_jq = 40000;
    //��ʼ��̹��λ��ʱ�����߾���������̾���
    //����һ��ʼ��̹�˵�λ�÷ŵ�ɽ����ȥ
    public static float length_to_terrain = 250;
    //��ʼ��̹��λ��ʱ��y�᷽��Ĺ̶��߶ȣ�����ڵ�����ߴ���y����
    public static float position_csh_y = 300;

    public float bj_pyl = 5.0f;//�߽�ƫ����
    //��which_step=0ʱ̹�˿�ʼ��������Ϸ��ʼ
    public static int which_step = -1;

    /**
     * ��ʼ������
     * */
    private void initial_data()
    {
        begin_time = 0;//��ʼʱ��
        tk_cur_num = 0;
        money = 500;//����
        tk_des_num = 0;
        ter_width = my_ter.terrainData.size.x;
        ter_length = my_ter.terrainData.size.z;
        ter_height = my_ter.terrainData.size.y;
    }

    /**
     * �Ե�����ǹ��̹�ˡ���������ά�޳���˾�����ʵ����
     * */

    private void initial_weapon()
    {
        /**
         * ���عؿ�����
         *�������ļ�·�����ļ������ؿ�ֵ
         * */
        LoadFile(Application.dataPath, "FileName", num_guanqia);

        // Debug.Log(Application.persistentDataPath);
        //��ʼ��̹��������λ��
        initial_tkVec();
    }

    /**
     * ��ȡ��Ӧ�ؿ��ĳ�ʼ������
     * path����ȡ�ļ���·�� 
     * name����ȡ�ļ�������
     * _num:�ؿ�ֵ 
     **/
    private void LoadFile(string path, string name, int _num)
    {
        string num = _num.ToString();
        string[] strs;
        //ʹ��������ʽ��ȡ
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(path + "//" + name);
            Debug.Log(path);
        }
        catch (System.Exception e)
        {
            //·��������δ�ҵ��ļ���ֱ�ӷ��ؿ�
            //return null;
            Debug.Log("cann't find data file!" + e.Message);
        }
        string line = sr.ReadLine();
        do
        {
            strs = line.Split(',');
        } while (strs[0] != num && (line = sr.ReadLine()) != null);
        Debug.Log("guan qia zhi:" + strs[0]);
        //�ر���
        sr.Close();
        //������
        sr.Dispose();

        //��ǹ�ĳ�ʼ��λ��
        string[] strs_child = strs[1].Split(' ');
        local_jq = new Vector3(float.Parse(strs_child[0]), float.Parse(strs_child[1]), float.Parse(strs_child[2]));
        //��ǹ�ĳ�ʼ������ֵ
        jq_values = int.Parse(strs[2]);
        //��ǹʵ����
        Instantiate(tran_jq, local_jq, Quaternion.identity);

        //��ʼʵ����̹������
        num_tk = int.Parse(strs[3]);
        //̹�˵ĳ�ʼ������ֵ
        tk_values = int.Parse(strs[4]);

        //�������ĳ�ʼ������ֵ
        factory_values = int.Parse(strs[6]);
        //�������ĳ�ʼ��λ��
        strs_child = strs[5].Split(' ');
        //����������
        int tp = strs_child.Length / 3;
        factory_num = tp;

        Vector3[] local_factory = new Vector3[tp];
        for (int i = 0; i < tp; i++)
        {
            local_factory[i] = new Vector3(float.Parse(strs_child[i * 3]), float.Parse(strs_child[i * 3 + 1]), float.Parse(strs_child[i * 3 + 2]));
            //������ʵ����
            Instantiate(tran_factory, local_factory[i], Quaternion.identity);
        }
        //̹���������ֵ
        tk_max_num = int.Parse(strs[7]);
    }

    /**
     * ��ʼʵ����̹��
     * */
    private void initial_tkVec()
    {
        Vector3 temp_vec;
        RaycastHit hit;
        Object go;

        Ray ray;
        float x, z;
        float _x, _z;
        //��¼��ǹ��x��z����
        _x = tran_jq.position.x;
        _z = tran_jq.position.z;
        int count_temp = 0;

        while (count_temp < num_tk)
        {
            //����ڵ�ͼ��Χ�ڵ����λ��
            x = Random.Range(bj_pyl, ter_width - bj_pyl);
            z = Random.Range(bj_pyl, ter_length - bj_pyl);
            temp_vec = new Vector3(x, position_csh_y, z);
            //�����ȷ����λ����-Y�ᷢ��һ������
            ray = new Ray(temp_vec, new Vector3(0.0f, -1.0f, 0.0f));
            Physics.Raycast(ray, out hit, ter_height + 100);
            //�ж�λ���Ƿ����
            //��λ�þ����ǹ�㹻Զ������û����ɽ����ʱ����Ϊλ�ú���
            if ((x - _x) * (x - _x) + (z - _z) * (z - _z) > length_to_jq && hit.distance > length_to_terrain)
            {
                Vector3 v3 = hit.point;
                v3.y = v3.y + 5;
                //ʵ����̹��
                go = Instantiate(tran_tk, v3, Quaternion.identity);
                go.name = "tk_" + tk_cur_num;
                tk_cur_num = tk_cur_num + 1;

                count_temp++;
            }
        }
    }

    void Awake()
    {
        initial_data();
        initial_weapon();
    }
}
