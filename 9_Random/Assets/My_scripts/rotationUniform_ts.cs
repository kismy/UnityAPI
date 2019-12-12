using UnityEngine;
using System.Collections;

public class rotationUniform_ts : MonoBehaviour
{
    public GameObject go;
    GameObject cb, sp;
    GameObject cb1, sp1;

    void Start()
    {
        //分别获取cb、sp、cb1和sp1对象
        cb = GameObject.Find("Cube");
        sp = GameObject.Find("Cube/Sphere");
        cb1 = GameObject.Find("Cube1");
        sp1 = GameObject.Find("Cube1/Sphere1");
        //每隔0.4秒执行一次use_rotationUniform方法
        InvokeRepeating("use_rotationUniform", 1.0f, 0.4f);
    }

    void use_rotationUniform()
    {
        //使用rotationUniform产生符合均匀分布特征的rotation
        cb.transform.rotation = Random.rotationUniform;
        //使用rotation产生一个随机rotation
        cb1.transform.rotation = Random.rotation;
        //分别在sp和sp1的位置实例化一个GameObject对象
        Instantiate(go, sp.transform.position, Quaternion.identity);
        Instantiate(go, sp1.transform.position, Quaternion.identity);
    }
}
