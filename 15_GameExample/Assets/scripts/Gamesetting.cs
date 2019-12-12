using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
/**
 * 全局设置，用于控制每局游戏中对象的实例化
 * */

public class Gamesetting : MonoBehaviour
{
    //指定Transform
    public Transform tran_tk;//坦克
    public Transform tran_factory;//兵工厂
    public Transform tran_jq;//机枪

    //用于记录每局游戏的开始时间
    public static float begin_time;

    public int num_guanqia = 1;//当前关卡值，用于确定导入哪个关卡数据
    public static Vector3 local_jq;//机枪的初始化位置
    public static int jq_values;//机枪的初始化生命值
    public static int num_tk;//初始化坦克数量
    public static int tk_values;//坦克的初始化生命值
    public static int factory_values;//兵工厂的初始化生命值
    public static int tk_max_num;//坦克数量的最大值

    public static int factory_num;//兵工厂数量
    public static int money;//积分值记录，机枪每补充一次血要消耗一定积分

    public int tk_cur_num;//当前场景中坦克名字的最大值，用于给新实例化的坦克命名
    public static int tk_des_num;//击毁坦克数量

    public Terrain my_ter;//获取当前战场地形以便获取其相关信息
    public float ter_width;//地形宽度，x
    public float ter_length;//地形长度，z
    public static float ter_height;//地形高度，y

    //初始化坦克位置时，坦克距离机枪的最近距离的平方值
    //一般而言，游戏开始时，坦克需要从远处接近机枪位置，当到达坦克的有效射程时便对机枪进行攻击
    //应避免一开始就把坦克的位置放的距离机枪太近
    public static float length_to_jq = 40000;
    //初始化坦克位置时，射线距离地面的最短距离
    //避免一开始把坦克的位置放到山顶上去
    public static float length_to_terrain = 250;
    //初始化坦克位置时，y轴方向的固定高度，须高于地形最高处的y坐标
    public static float position_csh_y = 300;

    public float bj_pyl = 5.0f;//边界偏移量
    //当which_step=0时坦克开始启动，游戏开始
    public static int which_step = -1;

    /**
     * 初始化数据
     * */
    private void initial_data()
    {
        begin_time = 0;//开始时间
        tk_cur_num = 0;
        money = 500;//积分
        tk_des_num = 0;
        ter_width = my_ter.terrainData.size.x;
        ter_length = my_ter.terrainData.size.z;
        ter_height = my_ter.terrainData.size.y;
    }

    /**
     * 对导弹机枪、坦克、兵工厂、维修厂和司令部进行实例化
     * */

    private void initial_weapon()
    {
        /**
         * 加载关卡数据
         *参数：文件路径、文件名、关卡值
         * */
        LoadFile(Application.dataPath, "FileName", num_guanqia);

        // Debug.Log(Application.persistentDataPath);
        //初始化坦克数量及位置
        initial_tkVec();
    }

    /**
     * 读取相应关卡的初始化数据
     * path：读取文件的路径 
     * name：读取文件的名称
     * _num:关卡值 
     **/
    private void LoadFile(string path, string name, int _num)
    {
        string num = _num.ToString();
        string[] strs;
        //使用流的形式读取
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(path + "//" + name);
            Debug.Log(path);
        }
        catch (System.Exception e)
        {
            //路径与名称未找到文件则直接返回空
            //return null;
            Debug.Log("cann't find data file!" + e.Message);
        }
        string line = sr.ReadLine();
        do
        {
            strs = line.Split(',');
        } while (strs[0] != num && (line = sr.ReadLine()) != null);
        Debug.Log("guan qia zhi:" + strs[0]);
        //关闭流
        sr.Close();
        //销毁流
        sr.Dispose();

        //机枪的初始化位置
        string[] strs_child = strs[1].Split(' ');
        local_jq = new Vector3(float.Parse(strs_child[0]), float.Parse(strs_child[1]), float.Parse(strs_child[2]));
        //机枪的初始化生命值
        jq_values = int.Parse(strs[2]);
        //机枪实例化
        Instantiate(tran_jq, local_jq, Quaternion.identity);

        //初始实例化坦克数量
        num_tk = int.Parse(strs[3]);
        //坦克的初始化生命值
        tk_values = int.Parse(strs[4]);

        //兵工厂的初始化生命值
        factory_values = int.Parse(strs[6]);
        //兵工厂的初始化位置
        strs_child = strs[5].Split(' ');
        //兵工厂数量
        int tp = strs_child.Length / 3;
        factory_num = tp;

        Vector3[] local_factory = new Vector3[tp];
        for (int i = 0; i < tp; i++)
        {
            local_factory[i] = new Vector3(float.Parse(strs_child[i * 3]), float.Parse(strs_child[i * 3 + 1]), float.Parse(strs_child[i * 3 + 2]));
            //兵工厂实例化
            Instantiate(tran_factory, local_factory[i], Quaternion.identity);
        }
        //坦克数量最大值
        tk_max_num = int.Parse(strs[7]);
    }

    /**
     * 初始实例化坦克
     * */
    private void initial_tkVec()
    {
        Vector3 temp_vec;
        RaycastHit hit;
        Object go;

        Ray ray;
        float x, z;
        float _x, _z;
        //记录机枪的x、z坐标
        _x = tran_jq.position.x;
        _z = tran_jq.position.z;
        int count_temp = 0;

        while (count_temp < num_tk)
        {
            //获得在地图范围内的随机位置
            x = Random.Range(bj_pyl, ter_width - bj_pyl);
            z = Random.Range(bj_pyl, ter_length - bj_pyl);
            temp_vec = new Vector3(x, position_csh_y, z);
            //从随机确定的位置向-Y轴发射一条射线
            ray = new Ray(temp_vec, new Vector3(0.0f, -1.0f, 0.0f));
            Physics.Raycast(ray, out hit, ter_height + 100);
            //判断位置是否合适
            //当位置距离机枪足够远，并且没落在山顶上时即认为位置合适
            if ((x - _x) * (x - _x) + (z - _z) * (z - _z) > length_to_jq && hit.distance > length_to_terrain)
            {
                Vector3 v3 = hit.point;
                v3.y = v3.y + 5;
                //实例化坦克
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
