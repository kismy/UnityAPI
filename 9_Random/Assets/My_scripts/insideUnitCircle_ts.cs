using UnityEngine;
using System.Collections;

public class insideUnitCircle_ts : MonoBehaviour
{
    public GameObject go;

    void Start()
    {
        //每隔0.4秒执行一次use_rotationUniform方法
        InvokeRepeating("use_rotationUniform", 1.0f, 0.4f);
    }

    void use_rotationUniform()
    {
        //在半径为5的圆内随机位置实例化一个GameObject对象
        //Vector2实例转为Vector3时，z轴分量默认为0
        Instantiate(go, Random.insideUnitCircle * 5.0f, Quaternion.identity);
        //在半径为5的球内随机位置实例化一个GameObject对象
        Instantiate(go, Vector3.forward * 15.0f + 5.0f * Random.insideUnitSphere, Quaternion.identity);
        //在半径为5的球表面随机位置实例化一个GameObject对象
        Instantiate(go, Vector3.forward * 30.0f + 5.0f * Random.onUnitSphere, Quaternion.identity);
    }
}