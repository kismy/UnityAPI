using UnityEngine;
using System.Collections;

public class Capture_Use_ts : MonoBehaviour
{

    //td:用来指向屏幕截图
    Texture2D td = null;
    //txt_bg:用来指向文本输入的背景图片
    //可以指向一张纯色的图片，也可以自定义一个纯色的背景
    //本程序自定义了一个纯色的背景
    Texture2D txt_bg;
    //txt_w和txt_h用来记录文本框的宽度和高度
    int txt_w, txt_h;
    //my_save_path：用来记录截图的保存路径
    string my_save_path = "";
    //show_txt：用来记录输入的文本
    string show_txt = "在此输入";
    //my_colors:用来记录文本输入框的纹理颜色
    Color[] my_colors;
    //_w和_h用来记录my_colors的宽度和高度
    int _w, _h;
    //step：用来记录当前状态，step共有3种状态：
    //step=0时，是等待状态，等待在文本框中输入文本
    //step=1时，即点击“确定”按钮后，生成截图并保存
    //step=2时，读取截图信息
    //step=3时，是对读取的截图信息进行有选择的提取，并生成想要展示的内容
    int step = 0;
    //go：用来指向拼字所用物体对象
    public GameObject go;
    //gos：用来记录所有的go对象
    GameObject[] gos;
    //gos_max用来记录gos的最大容量
    int gos_max;
    //gos_cur用来记录gos当前使用值
    int gos_cur = 0;
    //is_show:用来记录图像矩阵中某个点是否需要展示物体
    bool[,] is_show;

    void Start()
    {
        //初始化文本框的宽度和高度
        txt_w = 200;
        txt_h = 80;
        //初始化截取区间的大小，为了避免边界识别错误，其值应该比文本框的宽度和高度少几个像素
        _w = txt_w;
        _h = txt_h;
        _w -= 5;
        _h -= 5;
        //自定义txt_bg纹理
        txt_bg = new Texture2D(txt_w, txt_h);
        Color[] tdc = new Color[txt_w * txt_h];
        for (int i = 0; i < txt_w * txt_h; i++)
        {
            //所用像素点颜色应相同
            tdc[i] = Color.white;
        }
        txt_bg.SetPixels(0, 0, txt_w, txt_h, tdc);

        is_show = new bool[_h, _w];
        //初始化gos_max,其值大小为_w * _h的三分之一在一般情况下就够用了
        gos_max = _w * _h / 3;
        //实例化gos，使其随机分布_w和_h的区间内
        gos = new GameObject[gos_max];
        for (int i = 0; i < gos_max; i++)
        {
            gos[i] = (GameObject)Instantiate(go, new Vector3(Random.value * _w, Random.value * _h, 10.0f), Quaternion.identity);
            gos[i].GetComponent<Capture_Use_Sub_ts>().toward = gos[i].transform.position;
        }
        //存储初始界面截图
        my_save_path = Application.persistentDataPath;
        Application.CaptureScreenshot(my_save_path + "/ts02.png");

    }

    void Update()
    {
        switch (step)
        {
            case 0:
                break;
            case 1:
                step = 0;
                //截图并保存
                my_save_path = Application.persistentDataPath;
                Application.CaptureScreenshot(my_save_path + "/ts02.png");
                //给电脑一点儿时间用来保存新截取的图片
                Invoke("My_WaitForSeconds", 0.4f);
                Debug.Log(my_save_path);
                break;
            case 2:
                //由于在读取截图纹理的时候，一帧之内可能无法读完
                //所以需要step=0，避免逻辑出现混乱
                step = 0;
                //读取截图信息
                my_save_path = Application.persistentDataPath;
                StartCoroutine(WaitLoad(my_save_path + "/ts02.png"));
                break;
            case 3:
                //在计算并生成展示信息的时候，一帧之内可能无法完成
                //所以需要step=0，避免逻辑出现混乱
                step = 0;
                //计算并生成展示信息
                Cum();
                break;
        }
    }

    //计算并生成展示信息
    void Cum()
    {
        if (td != null)
        {
            float ft;
            //ft:用来记录文本框左下角像素的R通道值，用来作为后面的参照
            ft = td.GetPixel(2, td.height - _h).r;
            //截取文本框纹理信息
            //需要注意的是，纹理坐标系和GUI坐标系不同
            //纹理坐标系以坐下角为原点，而GUI坐标系以左上角为原点
            //以2为x方向起点是为了避免截图边缘的痕迹
            my_colors = td.GetPixels(2, td.height - _h, _w, _h);
            int l = my_colors.Length;
            Debug.Log("length: " + l);
            //通过遍历my_colors的R值，将其与ft比较来确定是否需要展示物体
            for (int i = 0; i < l; i++)
            {
                is_show[i / _w, i % _w] = my_colors[i].r == ft ? false : true;
            }
            //根据is_show的值排列gos中物体的位置
            for (int i = 0; i < _h; i++)
            {
                for (int j = 0; j < _w; j++)
                {
                    if (is_show[i, j])
                    {
                        if (gos_cur < gos_max)
                        {
                            gos[gos_cur].GetComponent<Capture_Use_Sub_ts>().toward = new Vector3(j, i, 0.0f);
                            gos[gos_cur].SetActive(true);
                            gos_cur++;
                        }
                        //当当前gos数量不够用时需要扩充gos的容量
                        else
                        {
                            Debug.Log("容量过小");
                            int temps = gos_max;
                            //将gos容量扩大1.5倍
                            gos_max = (int)(gos_max * 1.5f);
                            GameObject[] tps = new GameObject[gos_max];
                            for (int k = 0; k < temps; k++)
                            {
                                tps[k] = gos[k];
                            }
                            for (int k = temps; k < gos_max; k++)
                            {
                                tps[k] = (GameObject)Instantiate(go, new Vector3(Random.value * _h, Random.value * _w, 10.0f), Quaternion.identity);
                                tps[k].GetComponent<Capture_Use_Sub_ts>().toward = tps[k].transform.position;
                            }

                            gos = new GameObject[gos_max];
                            gos = tps;

                            gos[gos_cur].GetComponent<Capture_Use_Sub_ts>().toward = new Vector3(j, i, 0.0f);
                            gos[gos_cur].SetActive(true);
                            gos_cur++;

                        }

                    }
                }
            }
            //隐藏gos中未曾用到的物体
            for (int k = gos_cur; k < gos_max; k++)
            {
                gos[k].SetActive(false);
            }
        }
    }
    //绘制界面
    void OnGUI()
    {
        //绘制纹理作为TextField的背景
        GUI.DrawTexture(new Rect(0.0f, 0.0f, txt_w, txt_h), txt_bg);
        GUIStyle gs = new GUIStyle();
        gs.fontSize = 50;
        show_txt = GUI.TextField(new Rect(0.0f, 0.0f, txt_w, txt_h), show_txt, 15, gs);

        if (GUI.Button(new Rect(0, 100, 80, 45), "确定"))
        {
            //取消在TextField中的焦点
            GUI.FocusControl(null);
            //重置gos_cur的值
            gos_cur = 0;
            step = 1;
        }
        //程序退出
        if (GUI.Button(new Rect(0, 155, 80, 45), "退出"))
        {
            Application.Quit();
        }
    }

    //加载图片
    IEnumerator WaitLoad(string fileName)
    {
        WWW wwwTexture = new WWW("file://" + fileName);
        Debug.Log(wwwTexture.url);
        yield return wwwTexture;
        td = wwwTexture.texture;
        step = 3;
    }
    //进入步骤2
    void My_WaitForSeconds()
    {
        step = 2;
    }
}