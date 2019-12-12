using UnityEngine;
using System.Collections;

/**
 * 兵工厂,用于生产坦克
 * */

public class Factory : MonoBehaviour
{
    public Transform tks;//实例化坦克对象
    private Vector3 creat_tk_position;//实例化坦克位置

    void Start()
    {
        //坦克实例化的位置与兵工厂的位置发生一定的偏移，以免模型之间产生发生穿透
        creat_tk_position = this.transform.position + new Vector3(10.0f, 4.0f, 10.0f);
        //游戏启动后2秒开始调用方法creat_tk，以后每隔10秒调用一次此方法
        InvokeRepeating("creat_tk", 2.0f, 10.0f);
    }
    //实例化坦克
    private void creat_tk()
    {
        //当游戏中坦克数量少于游戏设置的最大坦克数量时，实例化一辆新坦克
        if (Gamesetting.num_tk < Gamesetting.tk_max_num)
        {
            Gamesetting.num_tk++;
            Instantiate(tks, creat_tk_position, Quaternion.identity);
        }
    }
}
