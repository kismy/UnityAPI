using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
//设置和生成游戏关卡数据
public class Set_game_data : MonoBehaviour
{
    StringBuilder sb = new StringBuilder("", 256);
    //0关卡值
    string num = "1";
    //1机枪位置
    string jiqiang = "";
    //2机枪生命值
    string jqsmz = "222";
    //3初始化坦克数量
    string tks = "12";
    //4坦克生命值
    string tkz = "111";
    //5兵工厂位置
    string bgc = "";
    //6兵工厂生命值
    string bgcz = "333";
    //7最大坦克数量
    string max_tk_num = "15";

    void Start()
    {
        getDate();
        appends();
        //路径、文件名、信息
        CreateFile(Application.dataPath, "FileName", sb.ToString());
    }
    //一般而言，机枪和兵工厂的位置需要在地图上选取合适的位置
    //制作关卡游戏数据之前请先把机枪和兵工厂拖拽到地图上的合适位置
    private void getDate()
    {
        GameObject fsj1 = GameObject.FindGameObjectWithTag("jq");
        GameObject[] bgc1 = GameObject.FindGameObjectsWithTag("bgc");

        GameObject go;

        for (int i = 0; i < bgc1.Length; i++)
        {
            go = bgc1[i];
            bgc += go.transform.position.x + " " + go.transform.position.y + " " + go.transform.position.z;
            if (i != bgc1.Length - 1)
            {
                bgc += " ";
            }
        }

        jiqiang = fsj1.transform.position.x + " " + fsj1.transform.position.y + " " + fsj1.transform.position.z;
    }
    //拼接数据
    private void appends()
    {
        sb.Append(num);
        sb.Append(",");
        sb.Append(jiqiang);
        sb.Append(",");
        sb.Append(jqsmz);
        sb.Append(",");
        sb.Append(tks);
        sb.Append(",");
        sb.Append(tkz);
        sb.Append(",");
        sb.Append(bgc);
        sb.Append(",");
        sb.Append(bgcz);
        sb.Append(",");
        sb.Append(max_tk_num);
    }

    /**
    * path：文件创建目录
    * name：文件的名称
    * info：写入的内容
    */
    void CreateFile(string path, string name, string info)
    {
        //文件流信息
        StreamWriter sw;
        FileInfo t = new FileInfo(path + "//" + name);
        //输出数据存放路径
        Debug.Log(path);
        if (!t.Exists)
        {
            //如果此文件不存在则创建一个新的文件
            sw = t.CreateText();
        }
        else
        {
            //如果此文件存在则打开
            sw = t.AppendText();
        }
        //以行的形式写入信息 
        sw.WriteLine(info);
        //关闭流
        sw.Close();
        //销毁流
        sw.Dispose();
    }
}
